using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CaseImage
    {
        public int ImageId { get; set; }
        public int? CaseId { get; set; }
        public string Operation { get; set; }
        public string ImageType { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public string Filename { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ImageDate { get; set; }
        public int? CaseProcedureId { get; set; }
        public int CaseProcedureItemTypeId { get; set; }
        public bool IsPrimary { get; set; }

        public Case Case { get; set; }
        public CaseProcedure CaseProcedure { get; set; }
        public CaseProcedureItemType CaseProcedureItemType { get; set; }
    }
}
