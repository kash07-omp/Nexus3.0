namespace Nexus.Domain.Entities
{
    public class Planet
    {
        public int Id { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
