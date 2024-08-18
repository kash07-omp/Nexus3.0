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
        public int RequiredUpgradeMinerals => GetUpgradeCoste(Structure.BaseMinerales);
        [NotMapped]
        public int RequiredUpgradeChips => GetUpgradeCoste(Structure.BaseChips);
        [NotMapped]
        public int RequiredUpgradeHydrogen => GetUpgradeCoste(Structure.BaseHydrogen);
        [NotMapped]
        public int RequiredUpgradeCredits => GetUpgradeCoste(Structure.BaseCredits);
        [NotMapped]
        public int RequiredUpgradeEnergy => GetUpgradeCoste(Structure.BaseEnergy);
        #endregion

        public virtual Structure Structure { get; set; }
        public virtual Region Region { get; set; }

        public int GetUpgradeCoste(int baseCost)
        {
            if (Level == 0)
                return baseCost;

            // Sustituir 1.5 por Structure.CostMultiplier
            return (int)Math.Round(baseCost * Math.Pow(1.5, Level + 1));
        }
    }
}
