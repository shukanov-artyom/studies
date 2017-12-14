using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PreComputedValue
    {
        public int Id { get; set; }
        public int ItemType { get; set; }
        public int ItemId { get; set; }
        public int PreComputedValueType { get; set; }
        public int Value { get; set; }
    }
}
