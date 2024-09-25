namespace Nexus.Domain.Entities
{
    public class Fleet
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int? AdmiralCardId { get; set; }
        public virtual Card? AdmiralCard { get; set; }

        public virtual ICollection<Ship> Ships { get; set; } = new List<Ship>();
    }
}
