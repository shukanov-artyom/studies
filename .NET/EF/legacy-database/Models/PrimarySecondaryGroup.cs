using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PrimarySecondaryGroup
    {
        public int PrimaryGroupId { get; set; }
        public int SecondaryGroupId { get; set; }

        public Group PrimaryGroup { get; set; }
        public Group SecondaryGroup { get; set; }
    }
}
