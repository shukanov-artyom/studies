using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CaseShareGroup
    {
        public string CaseGuid { get; set; }
        public int? GroupId { get; set; }
        public DateTime? SharedOn { get; set; }
        public int CaseShareGroupId { get; set; }

        public Case CaseGu { get; set; }
        public Group Group { get; set; }
    }
}
