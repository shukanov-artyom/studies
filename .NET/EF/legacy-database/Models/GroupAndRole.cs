using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class GroupAndRole
    {
        public int GroupId { get; set; }
        public int RoleId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Group Group { get; set; }
        public Role Role { get; set; }
    }
}
