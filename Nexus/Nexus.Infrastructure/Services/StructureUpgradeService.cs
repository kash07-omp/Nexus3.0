using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;
using Nexus.Domain.Entities.Enums;
using Nexus.Infrastructure.Data;
using Nexus.Infrastructure.Services.Interfaces;

public class StructureUpgradeService : IStructureUpgradeService
{
    private readonly ApplicationDbContext _context;
    private readonly IResourceService _resourceService;
    private readonly IResourceCostCalculator _resourceCostCalculator;

    public StructureUpgradeService(
        ApplicationDbContext context,
        IResourceService resourceService,
        IResourceCostCalculator resourceCostCalculator)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _resourceService = resourceService ?? throw new ArgumentNullException(nameof(resourceService));
        _resourceCostCalculator = resourceCostCalculator ?? throw new ArgumentNullException(nameof(resourceCostCalculator));
    }

    public async Task<bool> BuildOrUpgradeStructureAsync(int regionId, int structureId)
    {
        var regionStructures = await _context.RegionStructures
            .Include(rs => rs.Structure)
            .Include(rs => rs.Region)
            .Where(rs => rs.RegionId == regionId)
            .ToListAsync();

        if (regionStructures.Any(rs => rs.UpgradedAt.HasValue))
            return false; // TODO: Handle error: Solo se puede construir un edificio a la vez

        var regionStructure = regionStructures.FirstOrDefault(rs => rs.RegionId == regionId && rs.StructureId == structureId);
        bool isNewStructure = regionStructure == null;

        if (isNewStructure)
        {
            var structure = await _context.Structures.FirstOrDefaultAsync(s => s.Id == structureId);

            Region region;
            if (regionStructures != null && regionStructures.Count > 0)
                region = regionStructures[0].Region;
            else
                region = await _context.Regions.FirstOrDefaultAsync(r => r.Id == regionId);

            if (structure == null || region == null)
                return false; // TODO: Handle error: No existe este edificio ni región (lanzar excepción)

            regionStructure = new RegionStructure
            {
                RegionId = regionId,
                StructureId = structureId,
                Level = 0,
                Structure = structure,
                Region = region
            };
        }

        if (!isNewStructure && !regionStructure.Structure.CanLevelUp)
            return false;

        var requiredResources = regionStructure.GetUpgradeCosts();

        bool canSpendResources = await _resourceService.SpendResourcesAsync(regionId, requiredResources);
        if (!canSpendResources)
            return false; // TODO: Handle error: No hay suficientes recursos

        int totalCost = _resourceCostCalculator.GetTotalCost(requiredResources);
        int upgradeSeconds = await GetUpgradeSeconds(regionStructure, totalCost);

        regionStructure.UpgradedAt = DateTime.UtcNow.AddSeconds(upgradeSeconds);

        if (isNewStructure)
            _context.RegionStructures.Add(regionStructure);

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task ProcessCompletedUpgradesAsync(int regionId)
    {
        var now = DateTime.UtcNow;

        var structuresToUpgrade = await _context.RegionStructures
            .Where(rs => rs.RegionId == regionId && rs.UpgradedAt.HasValue && rs.UpgradedAt.Value <= now)
            .ToListAsync();

        foreach (var structure in structuresToUpgrade)
        {
            structure.Level += 1;
            structure.UpgradedAt = null;
        }

        await _context.SaveChangesAsync();
    }

    public async Task<int> GetUpgradeSeconds(RegionStructure regionStructure, int totalCost)
    {
        int timeDivider = 3500;
        int upgradeHours = totalCost / timeDivider;

        // TODO: Replace with cards
        if (regionStructure.Region != null)
            upgradeHours -= (int)Math.Round(upgradeHours * 0.25);

        return upgradeHours * 60 * 60;
    }
}

