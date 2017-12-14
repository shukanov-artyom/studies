using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CaseStatus
    {
        public CaseStatus()
        {
            Case = new HashSet<Case>();
        }

        public int CaseStatusId { get; set; }
        public string Name { get; set; }

        public ICollection<Case> Case { get; set; }
    }
}
