using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PostNoteFile
    {
        public int PostNoteFileId { get; set; }
        public int PostNoteId { get; set; }
        public int UserId { get; set; }
        public int UploadFileTypeId { get; set; }
        public string BacketPath { get; set; }
        public string Name { get; set; }
        public bool IsPublic { get; set; }
        public DateTime ActionDate { get; set; }

        public PostNote PostNote { get; set; }
        public Users User { get; set; }
    }
}
