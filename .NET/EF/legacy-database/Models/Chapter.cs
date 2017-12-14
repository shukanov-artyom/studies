using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Chapter
    {
        public int ChapterId { get; set; }
        public int FieldId { get; set; }
        public string Name { get; set; }
        public int Sortorder { get; set; }

        public Field Field { get; set; }
    }
}
