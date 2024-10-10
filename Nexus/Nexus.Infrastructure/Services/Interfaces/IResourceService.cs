using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Services.Interfaces
{
    public interface IResourceService
    {
        Task<bool> SpendResourcesAsync(int regionId, List<RegionResource> requiredResources);
        Task UpdateRegionResourcesAsync(int regionId);
        int CalculateMineGainPerHour(RegionStructure regionStructure, int level, Card? governor);
    }
}
