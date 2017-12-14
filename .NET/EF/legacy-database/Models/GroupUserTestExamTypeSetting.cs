using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class GroupUserTestExamTypeSetting
    {
        public int GroupUserTestExamTypeSettingId { get; set; }
        public int GroupId { get; set; }
        public int UserTestExamTypeId { get; set; }

        public Group Group { get; set; }
        public UserTestExamType UserTestExamType { get; set; }
    }
}
