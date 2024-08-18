namespace Nexus.Domain.Entities
{
    public class Research
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<StructureRequiredResearch> StructureRequiredResearchs { get; set; }
        public virtual ICollection<ResearchRequiredResearch> ResearchRequiredResearchs { get; set; }
    }
}
