using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;
using Nexus.Infrastructure.Data;
using Nexus.Infrastructure.Services.Interfaces;

namespace Nexus.Infrastructure.Services
{
    public class ResourcesService : IResourceService
    {
        private readonly ApplicationDbContext _context;

        public ResourcesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task UpdateRegionResourcesAsync(int regionId)
        {
            const int EnergyResourceId = 7;

            var region = await _context.Regions
                .Include(r => r.GovernorCard)
                    .ThenInclude(c => c.Bonuses)
                .Include(r => r.RegionResources)
                .Include(r => r.RegionStructures)
                    .ThenInclude(rs => rs.Structure)
                        .ThenInclude(s => s.Mine)
                .FirstOrDefaultAsync(r => r.Id == regionId);

            if (region == null)
                throw new KeyNotFoundException($"Region with ID {regionId} not found.");

            var now = DateTime.UtcNow;
            var hoursElapsed = (now - region.UpdatedAt).TotalHours;

            int totalEnergyProduction = 0;
            int totalEnergyConsumption = 0;

            // Primera pasada: calcular producción y consumo de energía
            foreach (var regionStructure in region.RegionStructures)
            {
                var mine = regionStructure.Structure.Mine;
                if (mine == null)
                    continue;

                if (mine.ResourceId == EnergyResourceId)
                {
                    // Mina de energía
                    totalEnergyProduction += regionStructure.Level * mine.GainMultiplier;
                }
                else
                {
                    // Mina normal
                    totalEnergyConsumption += regionStructure.Level * regionStructure.Structure.BaseEnergy;
                }
            }

            int availableEnergy = totalEnergyProduction - totalEnergyConsumption;
            region.AvailableEnergy = availableEnergy;
            region.TotalEnergy = totalEnergyProduction;

            // Crear un diccionario para acceso rápido a los recursos de la región
            var regionResourceDict = region.RegionResources.ToDictionary(rr => rr.ResourceId);

            // Segunda pasada: calcular ganancias de recursos
            foreach (var regionStructure in region.RegionStructures)
            {
                var mine = regionStructure.Structure.Mine;
                if (mine == null || mine.ResourceId == EnergyResourceId)
                    continue;

                var resourceGain = CalculateResourceGain(regionStructure, region.UpdatedAt, now, region.GovernorCard, availableEnergy);

                if (resourceGain <= 0)
                    continue;

                if (regionResourceDict.TryGetValue(mine.ResourceId, out var regionResource))
                {
                    regionResource.Quantity += resourceGain;
                }
                else
                {
                    var newResource = new RegionResource
                    {
                        RegionId = region.Id,
                        ResourceId = mine.ResourceId,
                        Quantity = resourceGain
                    };
                    region.RegionResources.Add(newResource);
                    regionResourceDict[mine.ResourceId] = newResource;
                }
            }

            region.UpdatedAt = now;
            await _context.SaveChangesAsync();
        }


        public async Task<bool> SpendResourcesAsync(int regionId, List<RegionResource> requiredResources)
        {
            var region = await _context.Regions
                .Include(r => r.RegionResources)
                .FirstOrDefaultAsync(r => r.Id == regionId);

            if (region == null)
                throw new Exception("Region not found");

            // Actualizar los recursos de la región antes de intentar gastarlos
            await UpdateRegionResourcesAsync(regionId);

            foreach (var requiredResource in requiredResources)
            {
                var regionResource = region.RegionResources.FirstOrDefault(rr => rr.ResourceId == requiredResource.ResourceId);
                if (regionResource == null || regionResource.Quantity < requiredResource.Quantity)
                    return false; // No hay suficientes recursos

                regionResource.Quantity -= requiredResource.Quantity;
            }

            await _context.SaveChangesAsync();
            return true;
        }

        private int CalculateResourceGain(RegionStructure regionStructure, DateTime fromTime, DateTime toTime, Card? governor, int availableEnergy)
        {
            var totalGain = 0;
            var upgradedAt = regionStructure.UpgradedAt;

            if (upgradedAt.HasValue && upgradedAt > fromTime && upgradedAt < toTime)
            {
                var hoursBeforeUpgrade = (upgradedAt.Value - fromTime).TotalHours;
                totalGain += CalculateGain(regionStructure, hoursBeforeUpgrade, regionStructure.Level - 1, governor);

                var hoursAfterUpgrade = (toTime - upgradedAt.Value).TotalHours;
                totalGain += CalculateGain(regionStructure, hoursAfterUpgrade, regionStructure.Level, governor);
            }
            else
            {
                var hoursElapsed = (toTime - fromTime).TotalHours;
                totalGain += CalculateGain(regionStructure, hoursElapsed, regionStructure.Level, governor);
            }
            
            switch (availableEnergy) 
            {
                case < 5:
                    totalGain -= totalGain - (int)(totalGain * 0.2);
                    break;
                case < 10:
                    totalGain -= totalGain - (int)(totalGain * 0.5);
                    break;
                case < 15:
                    totalGain -= totalGain - (int)(totalGain * 0.8);
                    break;
                case < 20:
                    totalGain = 0;
                    break;
            }

            return totalGain;
        }

        public int CalculateMineGainPerHour(RegionStructure regionStructure, int level, Card? governor)
        {
            var mine = regionStructure.Structure.Mine;
            var gainPerHour = mine.GainMultiplier * level * Math.Pow(1.1, level);

            // Si hay un gobernador, verificar si tiene un bono de tipo ResourceProductionBoost
            if (governor != null)
            {
                foreach (var bonus in governor.Bonuses)
                {
                    if (bonus.BonusType == EBonusType.ResourceProductionBoost)
                    {
                        gainPerHour += gainPerHour * (bonus.Percentage / 100.0); // Aumentar el valor en función del porcentaje del bono
                    }
                }
            }

            return (int)gainPerHour;
        }

        private int CalculateGain(RegionStructure regionStructure, double hoursElapsed, int level, Card? governor)
        {
            return (int)(CalculateMineGainPerHour(regionStructure, level, governor) * hoursElapsed);
        }
    }
}
