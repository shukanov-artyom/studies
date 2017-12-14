using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureSkillActionHistory
    {
        public int ProcedureSkillActionHistoryId { get; set; }
        public int ProcedureSkillId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int ProcedureSkillApprovalStateId { get; set; }
        public DateTime LastActionDate { get; set; }
        public DateTime? EnteredDate { get; set; }
        public string EnteredLocation { get; set; }
        public int? EnteredFacultyToGradeUserId { get; set; }
        public string EnteredVisualSignUrl { get; set; }
        public DateTime? GradedDate { get; set; }
        public int? GradedFacultyUserId { get; set; }
        public int? GradedGrade { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? ApprovedCccuserId { get; set; }
        public string Comment { get; set; }
        public DateTime RealEnteredDate { get; set; }

        public Users ApprovedCccuser { get; set; }
        public Users EnteredFacultyToGradeUser { get; set; }
        public Users GradedFacultyUser { get; set; }
        public Group Group { get; set; }
        public ProcedureSkill ProcedureSkill { get; set; }
        public ProcedureSkillApprovalState ProcedureSkillApprovalState { get; set; }
        public Users User { get; set; }
    }
}
