using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class BiannualReportData
    {
        public int BiannualReportDataId { get; set; }
        public int BiannualReportId { get; set; }
        public int UserId { get; set; }
        public int MedicalKnowledgeDomainModelJsonVersion { get; set; }
        public string MilestoneMedicalKnowlengeDomainModelJson { get; set; }
        public int MilestonePatientCareDomainModelJsonVersion { get; set; }
        public string MilestonePatientCareDomainModelJson { get; set; }
        public int MilestoneProfessionalismModelJsonVersion { get; set; }
        public string MilestoneProfessionalismModelJson { get; set; }
        public int ReportUserBoxJsonVersion { get; set; }
        public string ReportUserBoxJson { get; set; }
        public int MilestoneCommentsModelJsonVersion { get; set; }
        public string MilestoneCommentsModelJson { get; set; }

        public BiannualReport BiannualReport { get; set; }
        public Users User { get; set; }
    }
}
