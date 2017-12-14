using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class BiannualReportPracticeRecord
    {
        public int BiannualReportPracticeRecordId { get; set; }
        public int BiannualReportId { get; set; }
        public int UserId { get; set; }
        public int PassProfEvalId { get; set; }
        public decimal? AcceptedLevel { get; set; }
        public string Comment { get; set; }
        public decimal? OverriddenLevel { get; set; }
        public bool? IsOverriddenLevel { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public BiannualReport BiannualReport { get; set; }
        public PassProfEval PassProfEval { get; set; }
        public Users User { get; set; }
    }
}
