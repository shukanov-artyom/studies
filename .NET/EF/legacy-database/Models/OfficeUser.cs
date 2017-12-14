using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class OfficeUser
    {
        public int OfficeUserId { get; set; }
        public int OfficeId { get; set; }
        public int UserId { get; set; }
        public DateTime StartedYear { get; set; }
        public bool IsPrimary { get; set; }
        public string RoleDescription { get; set; }

        public Office Office { get; set; }
        public Users User { get; set; }
    }
}
