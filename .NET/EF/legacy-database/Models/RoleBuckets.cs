using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class RoleBuckets
    {
        public RoleBuckets()
        {
            GroupSettingsAssigned = new HashSet<GroupSettingsAssigned>();
            PassNotification = new HashSet<PassNotification>();
            RoleBucketAndPgy = new HashSet<RoleBucketAndPgy>();
        }

        public int BucketId { get; set; }
        public string BucketName { get; set; }
        public bool IsFakeBucket { get; set; }

        public ICollection<GroupSettingsAssigned> GroupSettingsAssigned { get; set; }
        public ICollection<PassNotification> PassNotification { get; set; }
        public ICollection<RoleBucketAndPgy> RoleBucketAndPgy { get; set; }
    }
}
