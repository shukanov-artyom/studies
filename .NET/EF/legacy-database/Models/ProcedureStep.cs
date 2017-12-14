using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureStep
    {
        public ProcedureStep()
        {
            ProcedureSkill = new HashSet<ProcedureSkill>();
        }

        public int ProcedureStepId { get; set; }
        public string Name { get; set; }
        public int ProcedureStepLevelId { get; set; }
        public string ProcedureStepDefaultDescription { get; set; }
        public int SpecialtyId { get; set; }

        public ProcedureStepLevel ProcedureStepLevel { get; set; }
        public ICollection<ProcedureSkill> ProcedureSkill { get; set; }
    }
}
