using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CaseShare
    {
        public string CaseGuid { get; set; }
        public int ToUserId { get; set; }
        public DateTime SharedOn { get; set; }
        public Guid CaseShareId { get; set; }

        public Case CaseGu { get; set; }
        public Users ToUser { get; set; }
    }
}
