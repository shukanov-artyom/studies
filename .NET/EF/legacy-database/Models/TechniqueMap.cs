using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class TechniqueMap
    {
        public int TechniqueMapId { get; set; }
        public int? TopicId { get; set; }
        public string Title { get; set; }
        public int? Position { get; set; }
        public bool? IsHeader { get; set; }
        public string Color { get; set; }
        public int SubspecialtyId { get; set; }

        public Subspecialty Subspecialty { get; set; }
        public Topic Topic { get; set; }
    }
}
