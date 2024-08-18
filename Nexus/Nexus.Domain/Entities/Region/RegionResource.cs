namespace Nexus.Domain.Entities
{
    public class RegionResource
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public int ResourceId { get; set; }
        public int Quantity { get; set; }

        public virtual Region Region { get; set; }
        public virtual Resource Resource { get; set; }
    }
}
