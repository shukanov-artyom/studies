using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureStepLevel
    {
        public ProcedureStepLevel()
        {
            ProcedureSkill = new HashSet<ProcedureSkill>();
            ProcedureStep = new HashSet<ProcedureStep>();
        }

        public int ProcedureStepLevelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ResidencyYear { get; set; }

        public ICollection<ProcedureSkill> ProcedureSkill { get; set; }
        public ICollection<ProcedureStep> ProcedureStep { get; set; }
    }
}
