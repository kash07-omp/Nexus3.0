namespace Nexus.Domain.Entities
{
    public class ShipBuildQueue
    {
        public int Id { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }

        public int FleetId { get; set; }
        public Fleet Fleet { get; set; }

        public int ShipId { get; set; }
        public Ship Ship { get; set; }

        public DateTime CompletionTime { get; set; }
    }
}
