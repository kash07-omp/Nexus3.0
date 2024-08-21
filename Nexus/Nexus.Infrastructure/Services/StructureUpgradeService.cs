using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;
using Nexus.Domain.Entities.Enums;
using Nexus.Infrastructure.Data;
using Nexus.Infrastructure.Services;

public class StructureUpgradeService
{
    private readonly ApplicationDbContext _context;
    private readonly ResourcesService _resourcesService;

    public StructureUpgradeService(ApplicationDbContext context, ResourcesService resourcesService)
    {
        _context = context;
        _resourcesService = resourcesService;
    }
    
    public async Task<bool> BuildOrUpgradeStructureAsync(int regionId, int structureId)
    {
        RegionStructure regionStructure = await _context.RegionStructures
            .Include(rs => rs.Structure)
            .Include(rs => rs.Region)
            .FirstOrDefaultAsync(rs => rs.RegionId == regionId && rs.StructureId == structureId);

        bool newStructure = regionStructure == null;

        if (newStructure)
        {
            regionStructure = new RegionStructure()
            {
                RegionId = regionId,
                StructureId = structureId,
                Level = 0,
                Structure = await _context.Structures.FirstOrDefaultAsync(s => s.Id == structureId),
                Region = await _context.Regions.FirstOrDefaultAsync(s => s.Id == structureId)
            };
        }

        if (!newStructure && !regionStructure.Structure.CanLevelUp)
            return false;

        // Recursos requeridos para la mejora o construcción
        var requiredResources = new List<RegionResource>
        {
            new RegionResource { ResourceId = 1, Quantity = regionStructure.RequiredUpgradeMinerals }, // MINERALS
            new RegionResource { ResourceId = 2, Quantity = regionStructure.RequiredUpgradeChips },  // MICROCHIPS
            new RegionResource { ResourceId = 3, Quantity = regionStructure.RequiredUpgradeHydrogen },  // HYDROGEN
            //new RegionResource { ResourceId = 6, Quantity = regionStructure.RequiredUpgradeCredits },  // CREDITS
            //new RegionResource { ResourceId = 7, Quantity = regionStructure.RequiredUpgradeEnergy }  // ENERGY
        };

        var canSpendResources = await _resourcesService.SpendResourcesAsync(regionId, requiredResources);
        if (!canSpendResources)
            return false; // No hay suficientes recursos

        int totalCost = GetTotalCost(requiredResources);
        int upgradeSeconds = await GetUpgradeSeconds(regionStructure, totalCost);
        regionStructure.UpgradedAt = DateTime.UtcNow.AddSeconds(upgradeSeconds);

        if (newStructure)
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
        int upgradeHours = 0;
        
        upgradeHours = totalCost / timeDivider;

        // TODO: Sustituir esto por aplicar bonus de cartas de region que mejoren la velocidad de construcción a esta structure
        if (regionStructure.Region != null)
            upgradeHours -= (int)Math.Round(upgradeHours * 0.25);

        return upgradeHours * 60 * 60;
    }

    /// <summary>
    /// Gets the "total cost" of all resources
    /// </summary>
    /// <param name="requiredResources"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    private int GetTotalCost(List<RegionResource> requiredResources)
    {
        var costMultipliers = new Dictionary<EResource, double>
        {
            { EResource.MINERALS, 1.0 },
            { EResource.MICROCHIPS, 1.2 },
            { EResource.HYDROGEN, 1.5 },
            { EResource.FOOD, 0.5 },
            { EResource.POPULATION, 1.0 },
            { EResource.CREDITS, 0.8 },
            { EResource.ENERGY, 1.0 }
        };

        int totalCost = 0;

        foreach (var resource in requiredResources)
            totalCost += (int)(resource.Quantity * costMultipliers[(EResource)resource.ResourceId]);

        return totalCost;
    }

}
