using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Services.Interfaces
{
    public interface IStructureUpgradeService
    {
        Task<bool> BuildOrUpgradeStructureAsync(int regionId, int structureId);
        Task ProcessCompletedUpgradesAsync(int regionId);
        Task<int> GetUpgradeSeconds(RegionStructure regionStructure, int totalCost);
    }
}
