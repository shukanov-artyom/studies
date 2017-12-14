using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class GroupSettingType
    {
        public GroupSettingType()
        {
            GroupSettings = new HashSet<GroupSettings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<GroupSettings> GroupSettings { get; set; }
    }
}
