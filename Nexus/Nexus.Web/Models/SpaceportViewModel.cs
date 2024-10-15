using Nexus.Domain.Entities;

namespace Nexus.Web.Models
{
    public class SpaceportViewModel
    {
        public Region Region { get; set; }
        public List<Fleet> Fleets { get; set; }
        public List<Ship> Ships { get; set; }
        public Fleet SelectedFleet { get; set; }
    }
}
