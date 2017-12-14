using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureSkillApprovalState
    {
        public ProcedureSkillApprovalState()
        {
            ProcedureSkillActionHistory = new HashSet<ProcedureSkillActionHistory>();
        }

        public int ProcedureSkillApprovalStateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<ProcedureSkillActionHistory> ProcedureSkillActionHistory { get; set; }
    }
}
