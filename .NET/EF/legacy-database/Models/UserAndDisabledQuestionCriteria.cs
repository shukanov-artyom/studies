using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserAndDisabledQuestionCriteria
    {
        public int UserAndDisabledQuestionCriteriaId { get; set; }
        public int UserId { get; set; }
        public int CriteriaId { get; set; }
        public int SpecialtyId { get; set; }
        public string CriteriaType { get; set; }

        public Specialty Specialty { get; set; }
        public Users User { get; set; }
    }
}
