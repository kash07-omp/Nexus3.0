using System.Data.Entity.Core.Metadata.Edm;

namespace Nexus.Domain.Entities
{
    public class Ship
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public EShipFunction Function { get; set; }

        public int FleetId { get; set; }
        public virtual Fleet Fleet { get; set; }
    }

    public enum EShipFunction
    {
        Transport,
        FastAttack,
        Attack,
        Heavy,
        Mothership
    }
}
