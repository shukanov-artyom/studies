using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PassProfEvalScoreHint
    {
        public int PassProfEvalScoreHintId { get; set; }
        public int PassProfEvalId { get; set; }
        public int PassProfScoreId { get; set; }
        public string Name { get; set; }
        public string Hint { get; set; }

        public PassProfEval PassProfEval { get; set; }
        public PassProfScore PassProfScore { get; set; }
    }
}
