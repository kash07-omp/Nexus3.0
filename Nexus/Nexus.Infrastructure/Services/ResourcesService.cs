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
            var region = await _context.Regions
                .Include(r => r.GovernorCard)
                    .ThenInclude(c => c.Bonuses)
                .Include(r => r.RegionResources)
                .Include(r => r.RegionStructures)
                    .ThenInclude(rs => rs.Structure)
                        .ThenInclude(s => s.Mine)
                .FirstOrDefaultAsync(r => r.Id == regionId);

            if (region == null)
                throw new Exception("Region not found");

            var now = DateTime.UtcNow;
            var hoursElapsed = (now - region.UpdatedAt).TotalHours;

            foreach (var regionStructure in region.RegionStructures)
            {
                if (regionStructure.Structure.Mine != null)
                {
                    var resourceGain = CalculateResourceGain(regionStructure, region.UpdatedAt, now, region.GovernorCard);

                    var regionResource = region.RegionResources
                        .FirstOrDefault(rr => rr.ResourceId == regionStructure.Structure.Mine.ResourceId);

                    if (regionResource != null)
                    {
                        regionResource.Quantity += resourceGain;
                    }
                    else
                    {
                        _context.RegionResources.Add(new RegionResource
                        {
                            RegionId = region.Id,
                            ResourceId = regionStructure.Structure.Mine.ResourceId,
                            Quantity = resourceGain
                        });
                    }
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

        private int CalculateResourceGain(RegionStructure regionStructure, DateTime fromTime, DateTime toTime, Card? governor)
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

            return totalGain;
        }

        private int CalculateGain(RegionStructure regionStructure, double hoursElapsed, int level, Card? governor)
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

            return (int)(gainPerHour * hoursElapsed);
        }
    }
}
