using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class GroupQuestion
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string Discussion { get; set; }
        public string Reference1 { get; set; }
        public string Reference2 { get; set; }
        public string Reference3 { get; set; }
        public string Pmid1 { get; set; }
        public string Pmid2 { get; set; }
        public string Pmid3 { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? GroupId { get; set; }
    }
}
