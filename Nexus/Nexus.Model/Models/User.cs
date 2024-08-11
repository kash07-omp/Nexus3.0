using Microsoft.AspNet.Identity.EntityFramework;

namespace Nexus.Model
{
    public class User : IdentityUser
    {
        public virtual ICollection<Region> Regions { get; set; }
    }
}
