using Microsoft.AspNetCore.Identity;

namespace Nexus.Domain.Entities
{
    public class User : IdentityUser
    {
        public virtual ICollection<Region> Regions { get; set; } = new List<Region>();
        public virtual ICollection<Card> Cards { get; set; } = new List<Card>();
        public virtual ICollection<Fleet> Fleets { get; set; } = new List<Fleet>();
        public int Credits { get; set; }
    }
}
