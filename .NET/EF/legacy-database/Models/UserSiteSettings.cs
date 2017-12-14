using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserSiteSettings
    {
        public int UserId { get; set; }
        public bool ShowSelfMasteryForOtherUsersInPass { get; set; }

        public Users User { get; set; }
    }
}
