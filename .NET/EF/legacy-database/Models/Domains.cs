using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Domains
    {
        public Domains()
        {
            Clusters = new HashSet<Clusters>();
        }

        public int DomainId { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public bool? Active { get; set; }

        public ICollection<Clusters> Clusters { get; set; }
    }
}
