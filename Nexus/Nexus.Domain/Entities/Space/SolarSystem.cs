namespace Nexus.Domain.Entities
{
    public class SolarSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GridSizeX { get; set; } = 7;
        public int GridSizeY { get; set; } = 7;

        public virtual ICollection<Planet> Planets { get; set; }
        public virtual ICollection<Fleet> Fleets { get; set; }
        public virtual ICollection<AsteroidField> AsteroidFields { get; set; }
        public virtual ICollection<JumpGate> JumpGates { get; set; }
    }
}
