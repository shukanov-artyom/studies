using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Procedure
    {
        public Procedure()
        {
            ClustersProcedures = new HashSet<ClustersProcedures>();
            ProcedureBullet = new HashSet<ProcedureBullet>();
            ProcedureSkill = new HashSet<ProcedureSkill>();
            ProcedureSkillStepChapter = new HashSet<ProcedureSkillStepChapter>();
            ProcedureSkillStepEvidence = new HashSet<ProcedureSkillStepEvidence>();
            ProcedureSkillStepNote = new HashSet<ProcedureSkillStepNote>();
            ProcedureSkillStepProgress = new HashSet<ProcedureSkillStepProgress>();
            ProcedureSkillStepTagged = new HashSet<ProcedureSkillStepTagged>();
            ProcedureSkillTest = new HashSet<ProcedureSkillTest>();
            ProcedureSkillUserAction = new HashSet<ProcedureSkillUserAction>();
            ProcedureSkillVideo = new HashSet<ProcedureSkillVideo>();
            UserProcedure = new HashSet<UserProcedure>();
        }

        public int ProcedureId { get; set; }
        public string Name { get; set; }
        public int ProcedureComplexityId { get; set; }
        public int? Order { get; set; }
        public int TopicId { get; set; }
        public bool? BlockedFromRelease { get; set; }
        public string LogoUrl { get; set; }
        public string LogoLink { get; set; }
        public int SpecialtyId { get; set; }
        public int? SubspecialtyId { get; set; }

        public ProcedureComplexity ProcedureComplexity { get; set; }
        public Specialty Specialty { get; set; }
        public Subspecialty Subspecialty { get; set; }
        public Topic Topic { get; set; }
        public ICollection<ClustersProcedures> ClustersProcedures { get; set; }
        public ICollection<ProcedureBullet> ProcedureBullet { get; set; }
        public ICollection<ProcedureSkill> ProcedureSkill { get; set; }
        public ICollection<ProcedureSkillStepChapter> ProcedureSkillStepChapter { get; set; }
        public ICollection<ProcedureSkillStepEvidence> ProcedureSkillStepEvidence { get; set; }
        public ICollection<ProcedureSkillStepNote> ProcedureSkillStepNote { get; set; }
        public ICollection<ProcedureSkillStepProgress> ProcedureSkillStepProgress { get; set; }
        public ICollection<ProcedureSkillStepTagged> ProcedureSkillStepTagged { get; set; }
        public ICollection<ProcedureSkillTest> ProcedureSkillTest { get; set; }
        public ICollection<ProcedureSkillUserAction> ProcedureSkillUserAction { get; set; }
        public ICollection<ProcedureSkillVideo> ProcedureSkillVideo { get; set; }
        public ICollection<UserProcedure> UserProcedure { get; set; }
    }
}
