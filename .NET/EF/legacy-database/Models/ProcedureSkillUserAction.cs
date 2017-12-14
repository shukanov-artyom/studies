using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureSkillUserAction
    {
        public int ProcedureId { get; set; }
        public int ProcedureSkillId { get; set; }
        public int UserId { get; set; }
        public int ProcedureSkillUserActionTypeId { get; set; }
        public DateTime ActionDate { get; set; }

        public Procedure Procedure { get; set; }
        public ProcedureSkill ProcedureSkill { get; set; }
        public ProcedureSkillUserActionType ProcedureSkillUserActionType { get; set; }
        public Users User { get; set; }
    }
}
