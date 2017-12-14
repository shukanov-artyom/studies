using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureSkillStep
    {
        public ProcedureSkillStep()
        {
            ProcedureSkillStepNote = new HashSet<ProcedureSkillStepNote>();
            ProcedureSkillStepPearl = new HashSet<ProcedureSkillStepPearl>();
            ProcedureSkillStepPitfall = new HashSet<ProcedureSkillStepPitfall>();
            ProcedureSkillStepProgress = new HashSet<ProcedureSkillStepProgress>();
            ProcedureSkillStepTagged = new HashSet<ProcedureSkillStepTagged>();
        }

        public Guid Id { get; set; }
        public int? ProcedureSkillId { get; set; }
        public string Description { get; set; }
        public int? Level { get; set; }
        public int? Order { get; set; }
        public string ItemClass { get; set; }

        public ProcedureSkill ProcedureSkill { get; set; }
        public ICollection<ProcedureSkillStepNote> ProcedureSkillStepNote { get; set; }
        public ICollection<ProcedureSkillStepPearl> ProcedureSkillStepPearl { get; set; }
        public ICollection<ProcedureSkillStepPitfall> ProcedureSkillStepPitfall { get; set; }
        public ICollection<ProcedureSkillStepProgress> ProcedureSkillStepProgress { get; set; }
        public ICollection<ProcedureSkillStepTagged> ProcedureSkillStepTagged { get; set; }
    }
}
