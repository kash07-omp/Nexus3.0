namespace Nexus.Domain.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public int PlanetId { get; set; }
        public bool IsColonized { get; set; }
        public string? UserId { get; set; }
        public int? GovernorCardId { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Planet Planet { get; set; }
        public virtual User? User { get; set; }
        public virtual Card? GovernorCard { get; set; }

        public virtual ICollection<RegionResource> RegionResources { get; set; }
        public virtual ICollection<RegionStructure> RegionStructures { get; set; }
    }
}
