using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class BiannualReportPatientCareRecord
    {
        public int BiannualReportPatientCareRecordId { get; set; }
        public int BiannualReportId { get; set; }
        public int UserId { get; set; }
        public int ClusterId { get; set; }
        public decimal? AcceptedLevel { get; set; }
        public string Comment { get; set; }
        public decimal? OverriddenLevel { get; set; }
        public bool? IsOverriddenLevel { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public BiannualReport BiannualReport { get; set; }
        public Clusters Cluster { get; set; }
    }
}
