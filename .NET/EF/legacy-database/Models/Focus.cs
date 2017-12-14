using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Focus
    {
        public Focus()
        {
            TestQuestion = new HashSet<TestQuestion>();
        }

        public int Id { get; set; }
        public int FocusheadingId { get; set; }
        public string Focus1 { get; set; }
        public int Sortorder { get; set; }
        public int? DefaultLevelId { get; set; }

        public Level DefaultLevel { get; set; }
        public Focusheading Focusheading { get; set; }
        public ICollection<TestQuestion> TestQuestion { get; set; }
    }
}
