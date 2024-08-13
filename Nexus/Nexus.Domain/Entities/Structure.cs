namespace Nexus.Domain.Entities
{
    public class Structure
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public short? MineId { get; set; }
        public virtual Mine Mine { get; set; }
    }
}
