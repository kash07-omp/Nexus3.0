namespace Nexus.Domain.Entities
{
    public class FleetShip
    {
        public int FleetId { get; set; }
        public Fleet Fleet { get; set; }

        public int ShipId { get; set; }
        public Ship Ship { get; set; }

        public int Quantity { get; set; }  // Cuántas naves de este tipo hay en la flota
    }
}
