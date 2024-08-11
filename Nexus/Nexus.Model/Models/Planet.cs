using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.Model
{
    public class Planet
    {
        public int Id { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
