using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureSkillStepNote
    {
        public ProcedureSkillStepNote()
        {
            ProcedureSkillStepNoteFile = new HashSet<ProcedureSkillStepNoteFile>();
        }

        public int ProcedureSkillStepNoteId { get; set; }
        public int ProcedureId { get; set; }
        public int ProcedureSkillId { get; set; }
        public Guid ProcedureSkillStepId { get; set; }
        public int UserId { get; set; }
        public string Style { get; set; }
        public string Text { get; set; }
        public int? StartPosition { get; set; }
        public int? EndPosition { get; set; }
        public DateTime ActionDate { get; set; }
        public bool IsPublic { get; set; }
        public byte[] BulletMd5 { get; set; }
        public int? Number { get; set; }
        public bool? IsNote { get; set; }
        public bool? IsHighlight { get; set; }
        public int? HighlightNumber { get; set; }
        public string HighlightText { get; set; }
        public int SpecialtyId { get; set; }

        public Procedure Procedure { get; set; }
        public ProcedureSkill ProcedureSkill { get; set; }
        public ProcedureSkillStep ProcedureSkillStep { get; set; }
        public Specialty Specialty { get; set; }
        public Users User { get; set; }
        public ICollection<ProcedureSkillStepNoteFile> ProcedureSkillStepNoteFile { get; set; }
    }
}
