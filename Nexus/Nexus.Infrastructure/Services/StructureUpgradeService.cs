using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;
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
            .FirstOrDefaultAsync(rs => rs.RegionId == regionId && rs.StructureId == structureId);

        if (regionStructure == null)
        {
            regionStructure = new RegionStructure()
            {
                RegionId = regionId,
                StructureId = structureId,
                Level = 0,
                Structure = await _context.Structures.FirstOrDefaultAsync(s => s.Id == structureId)
            };
        }

        // Recursos requeridos para la mejora o construcción
        var requiredResources = new List<RegionResource>
        {
            new RegionResource { ResourceId = 1, Quantity = regionStructure.RequiredUpgradeMinerals }, // MINERALS
            new RegionResource { ResourceId = 2, Quantity = regionStructure.RequiredUpgradeChips },  // MICROCHIPS
            new RegionResource { ResourceId = 3, Quantity = regionStructure.RequiredUpgradeHydrogen },  // HYDROGEN
            new RegionResource { ResourceId = 4, Quantity = regionStructure.RequiredUpgradeCredits },  // CREDITS
            new RegionResource { ResourceId = 5, Quantity = regionStructure.RequiredUpgradeEnergy }  // ENERGY
        };

        // Verificar y gastar recursos
        var canSpendResources = await _resourcesService.SpendResourcesAsync(regionId, requiredResources);
        if (!canSpendResources)
            return false; // No hay suficientes recursos

        if (regionStructure == null)
        {
            // Construir nueva estructura
            regionStructure = new RegionStructure
            {
                RegionId = regionId,
                StructureId = structureId,
                Level = 0,
                UpgradedAt = DateTime.UtcNow.AddHours(1)
            };
            _context.RegionStructures.Add(regionStructure);
        }
        else
        {
            if (regionStructure.Structure.Mine != null && !regionStructure.UpgradedAt.HasValue)
            {
                // Mejorar estructura existente
                regionStructure.UpgradedAt = DateTime.UtcNow.AddHours(1);
            }
            else if (regionStructure.Structure.Mine == null)
            {
                // Estructura sin mina no se puede mejorar
                return false;
            }
        }

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
}
