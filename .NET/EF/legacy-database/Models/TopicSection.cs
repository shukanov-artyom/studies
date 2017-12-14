using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class TopicSection
    {
        public int SectionId { get; set; }
        public string Title { get; set; }
        public int? Position { get; set; }
        public bool? IsHeader { get; set; }
        public string Color { get; set; }
        public int SubspecialtyId { get; set; }

        public Subspecialty Subspecialty { get; set; }
    }
}
