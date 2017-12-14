using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class FreePdfStatisticsPrecalculatedUsersByMonth
    {
        public DateTime Date { get; set; }
        public Guid JournalClubId { get; set; }
        public int Unique { get; set; }
        public int NotUnique { get; set; }
    }
}
