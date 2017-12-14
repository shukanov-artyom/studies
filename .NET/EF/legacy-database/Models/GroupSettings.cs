using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class GroupSettings
    {
        public GroupSettings()
        {
            GroupSettingsAssigned = new HashSet<GroupSettingsAssigned>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int? Order { get; set; }
        public int GroupSettingTypeId { get; set; }

        public GroupSettingType GroupSettingType { get; set; }
        public ICollection<GroupSettingsAssigned> GroupSettingsAssigned { get; set; }
    }
}
