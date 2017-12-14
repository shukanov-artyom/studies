using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class AuthorsTeam
    {
        public int UserId { get; set; }
        public int SpecialtyId { get; set; }

        public Subspecialty Specialty { get; set; }
        public Users User { get; set; }
    }
}
