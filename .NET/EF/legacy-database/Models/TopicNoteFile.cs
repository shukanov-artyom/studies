using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class TopicNoteFile
    {
        public int TopicNoteFileId { get; set; }
        public int TopicNoteId { get; set; }
        public int UserId { get; set; }
        public int UploadFileTypeId { get; set; }
        public string BacketPath { get; set; }
        public string Name { get; set; }
        public bool IsPublic { get; set; }
        public DateTime ActionDate { get; set; }

        public TopicNote TopicNote { get; set; }
        public Users User { get; set; }
    }
}
