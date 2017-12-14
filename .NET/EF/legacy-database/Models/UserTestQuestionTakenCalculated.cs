using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserTestQuestionTakenCalculated
    {
        public int QuestionId { get; set; }
        public int SelectedAnswer { get; set; }
        public int Count { get; set; }
    }
}
