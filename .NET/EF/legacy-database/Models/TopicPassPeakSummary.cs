using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class TopicPassPeakSummary
    {
        public int TopicId { get; set; }
        public int UserId { get; set; }
        public DateTime TopicUpdatedAt { get; set; }
        public DateTime UserUpdatedAt { get; set; }
        public int? TopicSelfMastery { get; set; }
        public int? TopicSelfMasteryRounded { get; set; }
        public int? TestQuestionsSelfMastery { get; set; }
        public int? TestQuestionsSelfMasteryRounded { get; set; }
        public int? ArticlesSelfMastery { get; set; }
        public int? ArticlesSelfMasteryRounded { get; set; }
        public int? CasesSelfMastery { get; set; }
        public int? CasesSelfMasteryRounded { get; set; }
        public int? VideosSelfMastery { get; set; }
        public int? VideosSelfMasteryRounded { get; set; }
        public int? TgSkillTasksSelfMastery { get; set; }
        public int? TgSkillTasksSelfMasteryRounded { get; set; }
        public int? TgSelfMastery { get; set; }
        public int? TgSelfMasteryRounded { get; set; }
        public int? TgFaculty { get; set; }
        public int? TgFacultyRounded { get; set; }
        public DateTime UpdatedAt { get; set; }
        public byte[] RowVersion { get; set; }

        public Topic Topic { get; set; }
        public Users User { get; set; }
    }
}
