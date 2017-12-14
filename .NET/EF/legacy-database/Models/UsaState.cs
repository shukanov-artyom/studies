using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UsaState
    {
        public UsaState()
        {
            Listings = new HashSet<Listings>();
        }

        public string Id { get; set; }
        public string Value { get; set; }

        public ICollection<Listings> Listings { get; set; }
    }
}
