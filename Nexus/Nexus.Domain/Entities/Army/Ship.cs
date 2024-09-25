namespace Nexus.Domain.Entities
{
    public class Ship
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public EShipFunction Function { get; set; }

        // Ship attributes
        public int Strenght { get; set; }
        public int Shields { get; set; }
        public int Health { get; set; }
        public int Maniobrability { get; set; }
        public int Ability { get; set; }
        public int Speed { get; set; }
        public int CargoCapacity { get; set; }

        // Ship costs
        public int MineralsCost { get; set; }
        public int MicrochipsCost { get; set; }
        public int HydrogenCost { get; set; }
        public int CreditsCost { get; set; }
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
