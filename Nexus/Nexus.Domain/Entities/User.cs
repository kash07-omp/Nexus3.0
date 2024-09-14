﻿using Microsoft.AspNetCore.Identity;

namespace Nexus.Domain.Entities
{
    public class User : IdentityUser
    {
        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<Card> Cards { get; set; } = new List<Card>();
        public int Credits { get; set; }
    }
}
