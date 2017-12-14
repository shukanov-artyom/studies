using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PollResult
    {
        public int PollId { get; set; }
        public string Option { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int PollResultId { get; set; }

        public Users CreatedByNavigation { get; set; }
        public Poll Poll { get; set; }
    }
}
