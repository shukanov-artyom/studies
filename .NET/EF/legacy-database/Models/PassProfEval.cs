using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PassProfEval
    {
        public PassProfEval()
        {
            BiannualReportPracticeRecord = new HashSet<BiannualReportPracticeRecord>();
            PassProfEvalScoreHint = new HashSet<PassProfEvalScoreHint>();
            PassUserScoresItems = new HashSet<PassUserScoresItems>();
        }

        public int PassProfEvalId { get; set; }
        public int Active { get; set; }
        public int SortOrder { get; set; }
        public string Title { get; set; }
        public string ShortDescirption { get; set; }
        public string LongDescirption { get; set; }
        public string LinkToPdfInformation { get; set; }
        public int SpecialtyId { get; set; }
        public int PassEvalType { get; set; }

        public Specialty Specialty { get; set; }
        public ICollection<BiannualReportPracticeRecord> BiannualReportPracticeRecord { get; set; }
        public ICollection<PassProfEvalScoreHint> PassProfEvalScoreHint { get; set; }
        public ICollection<PassUserScoresItems> PassUserScoresItems { get; set; }
    }
}
