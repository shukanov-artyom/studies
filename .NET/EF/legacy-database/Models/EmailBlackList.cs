using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class EmailBlackList
    {
        public string Email { get; set; }
        public int? EmailOwnerUserId { get; set; }
        public string Reason { get; set; }
        public DateTime? AddedOn { get; set; }
        public int? AddedByUserId { get; set; }

        public Users AddedByUser { get; set; }
    }
}
