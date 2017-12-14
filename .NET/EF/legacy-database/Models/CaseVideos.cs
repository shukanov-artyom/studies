using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CaseVideos
    {
        public int CaseVideoId { get; set; }
        public Guid CaseGuid { get; set; }
        public int CaseId { get; set; }
        public int CaseVideoType { get; set; }
        public string OriginalFilename { get; set; }
        public string ConvertedFilename { get; set; }
        public string Operation { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ConvertJobId { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public string ConvertedVideoThumbUrl { get; set; }
        public DateTime? VideoDate { get; set; }
        public int? CaseProcedureId { get; set; }
        public int CaseProcedureItemTypeId { get; set; }

        public Case Case { get; set; }
        public CaseProcedure CaseProcedure { get; set; }
        public CaseProcedureItemType CaseProcedureItemType { get; set; }
    }
}
