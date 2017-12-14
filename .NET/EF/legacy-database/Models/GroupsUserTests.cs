using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class GroupsUserTests
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string TestCode { get; set; }

        public Group Group { get; set; }
        public UserTest TestCodeNavigation { get; set; }
    }
}
