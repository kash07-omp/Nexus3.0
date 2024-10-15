using Nexus.Domain.Entities;

namespace Nexus.Web.Models
{
    public class RegionShipDialog
    {
        public Region Region { get; set; }
        public Ship Ship { get; set; }
        public int MaxBuildableShips { get; set; }
    }
}
