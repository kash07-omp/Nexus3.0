namespace Nexus.Domain.Entities
{
    public class FleetMovementPath
    {
        public int Id { get; set; }
        public int FleetId { get; set; }
        public Fleet Fleet { get; set; }

        public int FromX { get; set; }
        public int FromY { get; set; }

        public int ToX { get; set; }
        public int ToY { get; set; }
        

        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
    }

}
