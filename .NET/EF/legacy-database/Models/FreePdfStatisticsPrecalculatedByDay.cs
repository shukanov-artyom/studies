using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class FreePdfStatisticsPrecalculatedByDay
    {
        public DateTime Date { get; set; }
        public Guid JournalClubId { get; set; }
        public string JournalClubName { get; set; }
        public int UniqueCount { get; set; }
    }
}
