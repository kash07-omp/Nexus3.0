using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Services.Interfaces
{
    public interface IResourceCostCalculator
    {
        int GetTotalCost(List<RegionResource> requiredResources);
    }
}
