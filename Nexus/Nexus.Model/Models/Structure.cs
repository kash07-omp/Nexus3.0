﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus.Model
{
    public class Structure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short? MineId { get; set; }
        public virtual Mine Mine { get; set; }
    }
}
