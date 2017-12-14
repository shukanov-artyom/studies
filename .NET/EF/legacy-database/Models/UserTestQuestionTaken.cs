using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserTestQuestionTaken
    {
        public string TestCode { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public int? SelectedAnswer { get; set; }
        public int? Seconds { get; set; }
        public DateTime? AnswerTime { get; set; }
        public int? PersonalOrderInTest { get; set; }
    }
}
