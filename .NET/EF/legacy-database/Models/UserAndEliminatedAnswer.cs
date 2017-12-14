using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserAndEliminatedAnswer
    {
        public int UserAndEliminatedAnswerId { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public string TestId { get; set; }
        public int EliminatedAnswer { get; set; }

        public Users User { get; set; }
    }
}
