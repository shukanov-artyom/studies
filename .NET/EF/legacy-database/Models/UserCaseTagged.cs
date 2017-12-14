using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserCaseTagged
    {
        public int CaseId { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }

        public Case Case { get; set; }
        public Users User { get; set; }
    }
}
