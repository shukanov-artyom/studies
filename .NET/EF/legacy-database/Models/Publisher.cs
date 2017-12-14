using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            JournalClub = new HashSet<JournalClub>();
        }

        public int PublisherId { get; set; }
        public string Name { get; set; }

        public ICollection<JournalClub> JournalClub { get; set; }
    }
}
