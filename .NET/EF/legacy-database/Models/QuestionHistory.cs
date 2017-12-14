using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class QuestionHistory
    {
        public int HistoryId { get; set; }
        public int? QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int? Answer { get; set; }
        public string Discussion { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public string Reference1 { get; set; }
        public string Reference2 { get; set; }
        public string Reference3 { get; set; }
        public string Reference4 { get; set; }
        public string Reference5 { get; set; }
        public string Reference6 { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
