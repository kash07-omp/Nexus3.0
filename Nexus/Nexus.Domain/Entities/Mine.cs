namespace Nexus.Domain.Entities
{
    public class Mine
    {
        public short Id { get; set; }
        public required string Code { get; set; }
        public decimal GainMultiplier { get; set; }
        public int ResourceId { get; set; }

        public virtual Resource Resource { get; set; }
    }
}
