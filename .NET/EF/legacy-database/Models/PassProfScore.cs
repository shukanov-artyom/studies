using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PassProfScore
    {
        public PassProfScore()
        {
            PassProfEvalScoreHint = new HashSet<PassProfEvalScoreHint>();
            PassUserScoresItems = new HashSet<PassUserScoresItems>();
        }

        public int PassProfScoreId { get; set; }
        public int SortOrder { get; set; }
        public double? PassProfScore1 { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int SpecialtyId { get; set; }
        public int PassEvalType { get; set; }

        public Specialty Specialty { get; set; }
        public ICollection<PassProfEvalScoreHint> PassProfEvalScoreHint { get; set; }
        public ICollection<PassUserScoresItems> PassUserScoresItems { get; set; }
    }
}
