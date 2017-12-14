using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class GroupFile
    {
        public int FileId { get; set; }
        public string FileTitle { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Filename { get; set; }
        public string FileType { get; set; }
        public int? GroupId { get; set; }
        public string Pmid { get; set; }
        public string ReferenceType { get; set; }
    }
}
