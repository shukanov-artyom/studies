using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PartnershipTracks
    {
        public PartnershipTracks()
        {
            Listings = new HashSet<Listings>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<Listings> Listings { get; set; }
    }
}
