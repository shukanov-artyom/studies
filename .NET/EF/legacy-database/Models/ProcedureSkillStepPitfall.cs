using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureSkillStepPitfall
    {
        public Guid Id { get; set; }
        public Guid ProcedureSkillStepId { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }

        public ProcedureSkillStep ProcedureSkillStep { get; set; }
    }
}
