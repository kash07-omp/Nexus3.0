namespace Nexus.Domain.Entities
{
    public abstract class SolarSystemElement
    {
        public int Id { get; set; }
        public int SolarSystemId { get; set; }
        public virtual SolarSystem SolarSystem { get; set; }
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
    }
}