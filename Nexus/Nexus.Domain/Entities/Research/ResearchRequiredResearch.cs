namespace Nexus.Domain.Entities
{
    public class ResearchRequiredResearch
    {
        public int ResearchId { get; set; }
        public int RequiredResearchId { get; set; }

        public Research Research { get; set; }
        public Research RequiredResearch { get; set; }
    }
}
