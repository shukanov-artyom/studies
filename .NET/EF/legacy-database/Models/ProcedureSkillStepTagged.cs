using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureSkillStepTagged
    {
        public int ProcedureId { get; set; }
        public int ProcedureSkillId { get; set; }
        public Guid ProcedureSkillStepId { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }

        public Procedure Procedure { get; set; }
        public ProcedureSkill ProcedureSkill { get; set; }
        public ProcedureSkillStep ProcedureSkillStep { get; set; }
        public Users User { get; set; }
    }
}
