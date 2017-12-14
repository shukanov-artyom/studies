using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class MyGroups
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ExpireOn { get; set; }

        public Group Group { get; set; }
        public Users User { get; set; }
    }
}
