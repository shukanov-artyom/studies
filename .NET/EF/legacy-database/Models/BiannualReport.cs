using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class BiannualReport
    {
        public BiannualReport()
        {
            BiannualReportData = new HashSet<BiannualReportData>();
            BiannualReportKnowledgeRecord = new HashSet<BiannualReportKnowledgeRecord>();
            BiannualReportPatientCareRecord = new HashSet<BiannualReportPatientCareRecord>();
            BiannualReportPracticeRecord = new HashSet<BiannualReportPracticeRecord>();
            BiannualReportUser = new HashSet<BiannualReportUser>();
            PassuserAndCompetencyLevel = new HashSet<PassuserAndCompetencyLevel>();
        }

        public int BiannualReportId { get; set; }
        public int GroupId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public bool IsFinal { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastUpdate { get; set; }
        public string ReportTitle { get; set; }

        public Group Group { get; set; }
        public ICollection<BiannualReportData> BiannualReportData { get; set; }
        public ICollection<BiannualReportKnowledgeRecord> BiannualReportKnowledgeRecord { get; set; }
        public ICollection<BiannualReportPatientCareRecord> BiannualReportPatientCareRecord { get; set; }
        public ICollection<BiannualReportPracticeRecord> BiannualReportPracticeRecord { get; set; }
        public ICollection<BiannualReportUser> BiannualReportUser { get; set; }
        public ICollection<PassuserAndCompetencyLevel> PassuserAndCompetencyLevel { get; set; }
    }
}
