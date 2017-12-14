using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Level
    {
        public Level()
        {
            Focus = new HashSet<Focus>();
            TestQuestion = new HashSet<TestQuestion>();
            TestQuestionLevelHistoryCurentLevel = new HashSet<TestQuestionLevelHistory>();
            TestQuestionLevelHistoryPrevLevel = new HashSet<TestQuestionLevelHistory>();
        }

        public int Id { get; set; }
        public string Level1 { get; set; }
        public int SpecialtyId { get; set; }

        public Specialty Specialty { get; set; }
        public ICollection<Focus> Focus { get; set; }
        public ICollection<TestQuestion> TestQuestion { get; set; }
        public ICollection<TestQuestionLevelHistory> TestQuestionLevelHistoryCurentLevel { get; set; }
        public ICollection<TestQuestionLevelHistory> TestQuestionLevelHistoryPrevLevel { get; set; }
    }
}
