using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserTestResults
    {
        public string TestCode { get; set; }
        public int UserId { get; set; }
        public DateTime? StartedOn { get; set; }
        public DateTime? CompletedOn { get; set; }
    }
}
