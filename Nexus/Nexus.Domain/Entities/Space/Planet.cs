namespace Nexus.Domain.Entities
{
    public class Planet : SolarSystemElement
    {
        public virtual ICollection<Region> Regions { get; set; }
    }
}