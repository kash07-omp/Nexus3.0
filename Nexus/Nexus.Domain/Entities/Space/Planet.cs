namespace Nexus.Domain.Entities
{
    public class Planet
    {
        public int Id { get; set; }
        public int SolarSystemId { get; set; }
        public virtual SolarSystem SolarSystem { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
