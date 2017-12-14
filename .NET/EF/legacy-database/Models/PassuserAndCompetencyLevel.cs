using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PassuserAndCompetencyLevel
    {
        public int PassuserAndCompetencyLevelId { get; set; }
        public int UserId { get; set; }
        public int FacultyId { get; set; }
        public int GroupId { get; set; }
        public double GradeLevel { get; set; }
        public int GradeValue { get; set; }
        public DateTime GradeDate { get; set; }
        public int SystemDefault { get; set; }
        public string Comment { get; set; }
        public int? BiannualReportId { get; set; }

        public BiannualReport BiannualReport { get; set; }
        public Group Group { get; set; }
        public Users PassuserAndCompetencyLevel1 { get; set; }
        public PassuserAndCompetencyLevel PassuserAndCompetencyLevelNavigation { get; set; }
        public PassuserAndCompetencyLevel InversePassuserAndCompetencyLevelNavigation { get; set; }
    }
}
