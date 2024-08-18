namespace Nexus.Domain.Entities
{
    public class ResearchRequiredStructure
    {
        public int ResearchId { get; set; }
        public int RequiredStructureId { get; set; }
        public int RequiredStructureLevel { get; set; }

        public Research Research { get; set; }
        public Structure RequiredStructure { get; set; }
    }
}
