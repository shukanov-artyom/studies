using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserInternship
    {
        public int UserInternshipId { get; set; }
        public int UserId { get; set; }
        public int InternshipId { get; set; }

        public Internship Internship { get; set; }
        public Users User { get; set; }
    }
}
