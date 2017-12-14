using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Poll
    {
        public Poll()
        {
            Efootprint = new HashSet<Efootprint>();
            PollResult = new HashSet<PollResult>();
        }

        public int PollId { get; set; }
        public int PostId { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Option5 { get; set; }
        public string Option6 { get; set; }
        public string Option7 { get; set; }
        public string Option8 { get; set; }
        public string Option9 { get; set; }
        public string Option10 { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ItemType { get; set; }
        public int PositionOrder { get; set; }
        public string Option11 { get; set; }
        public string Option12 { get; set; }
        public string Option13 { get; set; }
        public int PollType { get; set; }

        public Users CreatedByNavigation { get; set; }
        public ICollection<Efootprint> Efootprint { get; set; }
        public ICollection<PollResult> PollResult { get; set; }
    }
}
