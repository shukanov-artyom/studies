using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class SkippedItems
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FeatureId { get; set; }
        public int FeatureType { get; set; }
        public bool Skipped { get; set; }
    }
}
