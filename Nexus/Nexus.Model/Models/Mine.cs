using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.Model
{
    public class Mine
    {
        public short Id { get; set; }
        public string Code { get; set; }
        public decimal GainMultiplier { get; set; }
        public int ResourceId { get; set; }
        public virtual Resource Resource { get; set; }
    }
}
