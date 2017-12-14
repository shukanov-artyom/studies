using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserNotification
    {
        public int UserId { get; set; }
        public bool? CommentReply { get; set; }
        public bool? CaseComment { get; set; }
        public bool? PrivateMessage { get; set; }
        public bool? ColleagueRequest { get; set; }
        public bool? SkillRequest { get; set; }
        public bool? EvalRequest { get; set; }
        public bool? WeeklyMonthlyReport { get; set; }
    }
}
