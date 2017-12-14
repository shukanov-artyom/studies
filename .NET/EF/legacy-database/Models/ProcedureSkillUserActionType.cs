using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureSkillUserActionType
    {
        public ProcedureSkillUserActionType()
        {
            ProcedureSkillUserAction = new HashSet<ProcedureSkillUserAction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProcedureSkillUserAction> ProcedureSkillUserAction { get; set; }
    }
}
