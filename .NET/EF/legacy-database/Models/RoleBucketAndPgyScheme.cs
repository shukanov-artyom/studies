using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class RoleBucketAndPgyScheme
    {
        public RoleBucketAndPgyScheme()
        {
            Group = new HashSet<Group>();
            RoleBucketAndPgy = new HashSet<RoleBucketAndPgy>();
        }

        public int SchemeId { get; set; }
        public string SchemeName { get; set; }

        public ICollection<Group> Group { get; set; }
        public ICollection<RoleBucketAndPgy> RoleBucketAndPgy { get; set; }
    }
}
