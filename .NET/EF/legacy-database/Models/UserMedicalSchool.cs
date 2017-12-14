using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserMedicalSchool
    {
        public int UserMedicalSchoolId { get; set; }
        public int UserId { get; set; }
        public int MedicalSchoolId { get; set; }
        public DateTime? YearOfGraduation { get; set; }
        public string Details { get; set; }
        public string Degree { get; set; }
        public int? EducationType { get; set; }

        public MedicalSchool MedicalSchool { get; set; }
        public Users User { get; set; }
    }
}
