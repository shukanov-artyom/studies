using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PassUserScoresItems
    {
        public int PassUserScoreItemId { get; set; }
        public int PassUserScoreId { get; set; }
        public int PassProfEvalId { get; set; }
        public int PassProffScoreId { get; set; }

        public PassProfEval PassProfEval { get; set; }
        public PassProfScore PassProffScore { get; set; }
        public PassUserScores PassUserScore { get; set; }
    }
}
