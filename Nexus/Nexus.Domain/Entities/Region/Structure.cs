namespace Nexus.Domain.Entities
{
    public class Structure
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public bool CanLevelUp { get; set; }
        public short? MineId { get; set; }
        public int DistrictId { get; set; }

        public int BaseMinerales { get; set; }
        public int BaseChips { get; set; }
        public int BaseHydrogen { get; set; }
        public int BaseEnergy { get; set; }
        public int BaseCredits { get; set; }

        public virtual Mine Mine { get; set; }
        public virtual District District { get; set; }
    }
}
