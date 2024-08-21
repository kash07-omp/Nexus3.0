using Nexus.Domain.Entities;
using Nexus.Domain.Entities.Enums;
using Nexus.Infrastructure.Services.Interfaces;

namespace Nexus.Infrastructure.Services
{
    public class ResourceCostCalculator : IResourceCostCalculator
    {
        private readonly Dictionary<EResource, double> _costMultipliers = new Dictionary<EResource, double>
        {
            { EResource.MINERALS, 1.0 },
            { EResource.MICROCHIPS, 1.2 },
            { EResource.HYDROGEN, 1.5 },
            { EResource.FOOD, 0.5 },
            { EResource.POPULATION, 1.0 },
            { EResource.CREDITS, 0.8 },
            { EResource.ENERGY, 1.0 }
        };

        public int GetTotalCost(List<RegionResource> requiredResources)
        {
            int totalCost = 0;
            foreach (var resource in requiredResources)
            {
                totalCost += (int)(resource.Quantity * _costMultipliers[(EResource)resource.ResourceId]);
            }
            return totalCost;
        }
    }

}
