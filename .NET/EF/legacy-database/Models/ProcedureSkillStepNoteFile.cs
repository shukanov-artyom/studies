using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureSkillStepNoteFile
    {
        public int ProcedureSkillStepNoteFileId { get; set; }
        public int ProcedureSkillStepNoteId { get; set; }
        public int UserId { get; set; }
        public int UploadFileTypeId { get; set; }
        public string BacketPath { get; set; }
        public string Name { get; set; }
        public bool IsPublic { get; set; }
        public DateTime ActionDate { get; set; }

        public ProcedureSkillStepNote ProcedureSkillStepNote { get; set; }
        public UploadFileType UploadFileType { get; set; }
        public Users User { get; set; }
    }
}
