using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class TestQuestionLevelHistory
    {
        public int TestQuestionLevelHistoryId { get; set; }
        public int QuestionId { get; set; }
        public int? PrevLevelId { get; set; }
        public int? CurentLevelId { get; set; }
        public int ChangedById { get; set; }
        public DateTime DateChanged { get; set; }

        public Users ChangedBy { get; set; }
        public Level CurentLevel { get; set; }
        public Level PrevLevel { get; set; }
        public TestQuestion Question { get; set; }
    }
}
