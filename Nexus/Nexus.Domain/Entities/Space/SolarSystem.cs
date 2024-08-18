namespace Nexus.Domain.Entities
{
    public class SolarSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Planet> Planets { get; set; }
    }
}
