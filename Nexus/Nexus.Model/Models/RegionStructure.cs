namespace Nexus.Model
{
    public class RegionStructure
    {
        public int StructureId { get; set; }
        public virtual Structure Structure { get; set; }
        public int RegionId { get; set; }
        public virtual Region Region { get; set; }
        public int Level { get; set; }
    }
}
