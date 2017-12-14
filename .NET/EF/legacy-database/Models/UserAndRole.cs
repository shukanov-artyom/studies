using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserAndRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Role Role { get; set; }
        public Users User { get; set; }
    }
}
