using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class GroupSettingsAssigned
    {
        public int Id { get; set; }
        public int GroupSettingId { get; set; }
        public int? BucketId { get; set; }
        public int GroupId { get; set; }
        public int? NumericValue { get; set; }

        public RoleBuckets Bucket { get; set; }
        public Group Group { get; set; }
        public GroupSettings GroupSetting { get; set; }
    }
}
