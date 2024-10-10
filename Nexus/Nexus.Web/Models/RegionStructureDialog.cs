using Nexus.Domain.Entities;

namespace Nexus.Web.Models
{
    public class RegionStructureDialog
    {
        public Region Region { get; set; }
        public RegionStructure RegionStructure { get; set; }

        public int ResourceGainPerSecond { get; set; }
        public int ResourceGainPerMinute { get; set; }
        public int ResourceGainPerHour { get; set; }
        public int ResourceGainPerDay { get; set; }
        public int ResourceGainPerWeek { get; set; }

        public string UpgradeTimeText { get; set; }
    }
}
