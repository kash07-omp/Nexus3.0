using Nexus.Domain.Entities;

namespace Nexus.Web.Models
{
    public class SolarSystemViewModel
    {
        public SolarSystem SolarSystem { get; set; }
        public User CurrentUser { get; set; }
    }
}