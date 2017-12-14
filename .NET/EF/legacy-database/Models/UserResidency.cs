using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserResidency
    {
        public int UserResidencyId { get; set; }
        public int UserId { get; set; }
        public int ResidencyId { get; set; }

        public Residency Residency { get; set; }
        public Users User { get; set; }
    }
}
