using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CaseProcedure
    {
        public CaseProcedure()
        {
            CaseImage = new HashSet<CaseImage>();
            CaseVideos = new HashSet<CaseVideos>();
        }

        public int CaseProcedureId { get; set; }
        public int CaseId { get; set; }
        public DateTime? DateOfSurgery { get; set; }
        public string OperationPerformed { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int Number { get; set; }

        public Case Case { get; set; }
        public ICollection<CaseImage> CaseImage { get; set; }
        public ICollection<CaseVideos> CaseVideos { get; set; }
    }
}
