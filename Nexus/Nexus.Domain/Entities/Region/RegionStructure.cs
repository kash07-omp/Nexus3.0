using Nexus.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nexus.Domain.Entities
{
    public class RegionStructure
    {
        public int StructureId { get; set; }
        public int RegionId { get; set; }
        public int Level { get; set; }
        public DateTime? UpgradedAt { get; set; }

        #region Upgrade Costs
        [NotMapped]
        public int RequiredUpgradeMinerals => GetUpgradeCost(Structure.BaseMinerales);
        [NotMapped]
        public int RequiredUpgradeChips => GetUpgradeCost(Structure.BaseChips);
        [NotMapped]
        public int RequiredUpgradeHydrogen => GetUpgradeCost(Structure.BaseHydrogen);
        [NotMapped]
        public int RequiredUpgradeCredits => GetUpgradeCost(Structure.BaseCredits);
        [NotMapped]
        public int RequiredUpgradeEnergy => GetUpgradeCost(Structure.BaseEnergy);
        #endregion

        public virtual Structure Structure { get; set; }
        public virtual Region Region { get; set; }

        public int GetUpgradeCost(int baseCost)
        {
            if (Level == 0)
                return baseCost;

            // Sustituir 1.5 por Structure.CostMultiplier
            return (int)Math.Round(baseCost * Math.Pow(1.5, Level + 1));
        }

        public List<RegionResource> GetUpgradeCosts()
        {
            return new List<RegionResource>
            {
                new RegionResource { ResourceId = (int)EResource.MINERALS, Quantity = RequiredUpgradeMinerals },
                new RegionResource { ResourceId = (int)EResource.MICROCHIPS, Quantity = RequiredUpgradeChips },
                new RegionResource { ResourceId = (int)EResource.HYDROGEN, Quantity = RequiredUpgradeHydrogen },
                //new RegionResource { ResourceId = (int)EResource.CREDITS, Quantity = regionStructure.RequiredUpgradeCredits },
                //new RegionResource { ResourceId = (int)EResource.ENERGY, Quantity = regionStructure.RequiredUpgradeEnergy }
            };
        }
    }
}
