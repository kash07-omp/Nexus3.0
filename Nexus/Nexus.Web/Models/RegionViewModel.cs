using Nexus.Domain.Entities;

namespace Nexus.Web.Models
{
    public class RegionViewModel
    {
        public Region Region { get; set; }
        public List<Structure> Structures { get; set; }
        public List<RegionStructure> RegionStructures { get; set; }
    }
}
