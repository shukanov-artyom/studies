using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class GroupAssociativity
    {
        public int GroupAssociativityId { get; set; }
        public int GroupId { get; set; }
        public int AssociatedGroupId { get; set; }

        public Group AssociatedGroup { get; set; }
        public Group Group { get; set; }
    }
}
