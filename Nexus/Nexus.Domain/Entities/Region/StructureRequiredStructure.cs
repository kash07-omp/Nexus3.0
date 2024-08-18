namespace Nexus.Domain.Entities
{
    public class StructureRequiredStructure
    {
        public int StructureId { get; set; }
        public int RequiredStructureId { get; set; }
        public int RequiredStructureLevel { get; set; }

        public Structure Structure { get; set; }
        public Structure RequiredStructure { get; set; }
    }
}
