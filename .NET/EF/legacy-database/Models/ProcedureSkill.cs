using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureSkill
    {
        public ProcedureSkill()
        {
            Comment = new HashSet<Comment>();
            ProcedureSkillActionHistory = new HashSet<ProcedureSkillActionHistory>();
            ProcedureSkillStep = new HashSet<ProcedureSkillStep>();
            ProcedureSkillStepChapter = new HashSet<ProcedureSkillStepChapter>();
            ProcedureSkillStepEvidence = new HashSet<ProcedureSkillStepEvidence>();
            ProcedureSkillStepNote = new HashSet<ProcedureSkillStepNote>();
            ProcedureSkillStepProgress = new HashSet<ProcedureSkillStepProgress>();
            ProcedureSkillStepTagged = new HashSet<ProcedureSkillStepTagged>();
            ProcedureSkillTest = new HashSet<ProcedureSkillTest>();
            ProcedureSkillUserAction = new HashSet<ProcedureSkillUserAction>();
            ProcedureSkillVideo = new HashSet<ProcedureSkillVideo>();
            Video = new HashSet<Video>();
        }

        public int ProcedureSkillId { get; set; }
        public int ProcedureId { get; set; }
        public int ProcedureStepId { get; set; }
        public int ProcedureStepLevelId { get; set; }
        public string ProcedureSkillStepName { get; set; }
        public string ProcedureSkillDescription { get; set; }
        public int? ResidencyYear { get; set; }
        public int? TopicId { get; set; }
        public string TopicAnchor { get; set; }
        public bool Active { get; set; }

        public Procedure Procedure { get; set; }
        public ProcedureStep ProcedureStep { get; set; }
        public ProcedureStepLevel ProcedureStepLevel { get; set; }
        public Topic Topic { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<ProcedureSkillActionHistory> ProcedureSkillActionHistory { get; set; }
        public ICollection<ProcedureSkillStep> ProcedureSkillStep { get; set; }
        public ICollection<ProcedureSkillStepChapter> ProcedureSkillStepChapter { get; set; }
        public ICollection<ProcedureSkillStepEvidence> ProcedureSkillStepEvidence { get; set; }
        public ICollection<ProcedureSkillStepNote> ProcedureSkillStepNote { get; set; }
        public ICollection<ProcedureSkillStepProgress> ProcedureSkillStepProgress { get; set; }
        public ICollection<ProcedureSkillStepTagged> ProcedureSkillStepTagged { get; set; }
        public ICollection<ProcedureSkillTest> ProcedureSkillTest { get; set; }
        public ICollection<ProcedureSkillUserAction> ProcedureSkillUserAction { get; set; }
        public ICollection<ProcedureSkillVideo> ProcedureSkillVideo { get; set; }
        public ICollection<Video> Video { get; set; }
    }
}
