using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserUniversity
    {
        public int UserUniversityId { get; set; }
        public int UserId { get; set; }
        public int UniversityId { get; set; }
        public DateTime? YearOfGraduation { get; set; }
        public string Details { get; set; }
        public string Degree { get; set; }
        public int? EducationType { get; set; }

        public University University { get; set; }
        public Users User { get; set; }
    }
}
