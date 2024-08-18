namespace Nexus.Domain.Entities
{
    public class StructureRequiredResearch
    {
        public int StructureId { get; set; }
        public int RequiredResearchId { get; set; }

        public Structure Structure { get; set; }
        public Research RequiredResearch { get; set; }
    }
}
