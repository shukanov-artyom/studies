using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UploadFileType
    {
        public UploadFileType()
        {
            ProcedureSkillStepNoteFile = new HashSet<ProcedureSkillStepNoteFile>();
        }

        public int UploadFileTypeId { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string MimeType { get; set; }
        public int Order { get; set; }

        public ICollection<ProcedureSkillStepNoteFile> ProcedureSkillStepNoteFile { get; set; }
    }
}
