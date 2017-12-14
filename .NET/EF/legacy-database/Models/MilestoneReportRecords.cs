using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class MilestoneReportRecords
    {
        public int RecordId { get; set; }
        public int ReportId { get; set; }
        public int UserId { get; set; }
        public int CorrectQuestionsCount { get; set; }
        public int QuestionsCount { get; set; }
        public string UserName { get; set; }
        public string UserMembership { get; set; }
        public int PatienCarePersentage { get; set; }
        public int ActiveSkillCount { get; set; }
        public int MonthPersentage { get; set; }
        public int ProfRequestCount { get; set; }
        public double ProfResultValue { get; set; }
        public decimal PatienCareSkillGrade { get; set; }

        public MilestoneReports Report { get; set; }
        public Users User { get; set; }
    }
}
