using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CaseProcedureItemType
    {
        public CaseProcedureItemType()
        {
            CaseImage = new HashSet<CaseImage>();
            CaseVideos = new HashSet<CaseVideos>();
        }

        public int CaseProcedureItemTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<CaseImage> CaseImage { get; set; }
        public ICollection<CaseVideos> CaseVideos { get; set; }
    }
}
