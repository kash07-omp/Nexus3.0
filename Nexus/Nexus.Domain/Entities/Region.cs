namespace Nexus.Domain.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public bool IsColonized { get; set; }
        public int? PlanetId { get; set; }
        public virtual Planet Planet { get; set; }
        //public int? UserId { get; set; }
        //public virtual User User { get; set; }

        public virtual ICollection<RegionStructure> RegionStructures { get; set; }
    }
}
