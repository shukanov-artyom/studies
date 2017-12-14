using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserTestExamType
    {
        public UserTestExamType()
        {
            GroupUserTestExamTypeSetting = new HashSet<GroupUserTestExamTypeSetting>();
            UserTest = new HashSet<UserTest>();
        }

        public int UserTestExamTypeId { get; set; }
        public string UserTestExamTypeEnum { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<GroupUserTestExamTypeSetting> GroupUserTestExamTypeSetting { get; set; }
        public ICollection<UserTest> UserTest { get; set; }
    }
}
