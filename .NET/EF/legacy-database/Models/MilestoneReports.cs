using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class MilestoneReports
    {
        public MilestoneReports()
        {
            MilestoneReportRecords = new HashSet<MilestoneReportRecords>();
        }

        public int ReportId { get; set; }
        public int GroupId { get; set; }
        public string Title { get; set; }
        public int MembersCount { get; set; }
        public int QuestionDomainCount { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime ReportDate { get; set; }
        public bool? IncludeLevel1 { get; set; }
        public bool? IncludeLevel2 { get; set; }
        public bool? IncludeLevel3 { get; set; }
        public bool? IncludeLevel4 { get; set; }
        public bool? IncludeLevel5 { get; set; }
        public bool? FilterByTargetLevel { get; set; }
        public int? QuestionDomainCountLevel1 { get; set; }
        public int? QuestionDomainCountLevel2 { get; set; }
        public int? QuestionDomainCountLevel3 { get; set; }
        public int? QuestionDomainCountLevel4 { get; set; }
        public int? QuestionDomainCountLevel5 { get; set; }
        public bool? IncludeMedicalKnowledge { get; set; }
        public bool? IncludePatientCare { get; set; }
        public bool? IncludeProfessionalism { get; set; }
        public bool? IsMilestoneReport { get; set; }
        public bool? IsMilestoneReportFinished { get; set; }

        public Group Group { get; set; }
        public ICollection<MilestoneReportRecords> MilestoneReportRecords { get; set; }
    }
}
