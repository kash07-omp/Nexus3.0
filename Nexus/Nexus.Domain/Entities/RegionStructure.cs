namespace Nexus.Domain.Entities
{
    public class RegionStructure
    {
        public int StructureId { get; set; }
        public int RegionId { get; set; }
        public int Level { get; set; }
        public DateTime? UpgradedAt { get; set; }

        public virtual Structure Structure { get; set; }
        public virtual Region Region { get; set; }
    }
}
