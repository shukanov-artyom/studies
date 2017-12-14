using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class OfficeContactDetail
    {
        public int OfficeContactDetailId { get; set; }
        public int OfficeId { get; set; }
        public int ContactDetailId { get; set; }

        public ContactDetail ContactDetail { get; set; }
        public Office Office { get; set; }
    }
}
