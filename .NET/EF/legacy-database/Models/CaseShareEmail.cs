using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CaseShareEmail
    {
        public string CaseGuid { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? SharedOn { get; set; }
        public Guid CaseShareEmailId { get; set; }

        public Case CaseGu { get; set; }
    }
}
