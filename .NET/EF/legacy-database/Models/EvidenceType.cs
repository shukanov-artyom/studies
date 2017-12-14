using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class EvidenceType
    {
        public EvidenceType()
        {
            Post = new HashSet<Post>();
        }

        public int EvidenceTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}
