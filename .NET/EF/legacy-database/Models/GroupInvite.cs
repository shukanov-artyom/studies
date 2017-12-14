using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class GroupInvite
    {
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
