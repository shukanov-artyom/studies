using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Focusheading
    {
        public Focusheading()
        {
            Focus = new HashSet<Focus>();
        }

        public int Id { get; set; }
        public string Focusheading1 { get; set; }
        public int Sortorder { get; set; }
        public int SpecialtyId { get; set; }

        public Specialty Specialty { get; set; }
        public ICollection<Focus> Focus { get; set; }
    }
}
