namespace Nexus.Domain.Entities
{
    public class Fleet
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int? SolarSystemId { get; set; }
        public virtual SolarSystem SolarSystem { get; set; }

        public int? AdmiralCardId { get; set; }
        public virtual Card? AdmiralCard { get; set; }

        public virtual ICollection<FleetShip> FleetShips { get; set; } = new List<FleetShip>();
        public virtual ICollection<FleetMovementPath> FleetMovementPaths { get; set; } = new List<FleetMovementPath>();
    }
}
