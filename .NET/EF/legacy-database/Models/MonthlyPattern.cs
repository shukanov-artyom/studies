using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class MonthlyPattern
    {
        public MonthlyPattern()
        {
            PassNotification = new HashSet<PassNotification>();
        }

        public int MonthlyPatternId { get; set; }
        public int? DayNumber { get; set; }
        public int? WeekNumber { get; set; }
        public int? DayOfWeek { get; set; }

        public ICollection<PassNotification> PassNotification { get; set; }
    }
}
