using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PassUserScores
    {
        public PassUserScores()
        {
            PassUserScoresItems = new HashSet<PassUserScoresItems>();
        }

        public int UserScoreId { get; set; }
        public int GroupId { get; set; }
        public int ResidentId { get; set; }
        public int FacultyId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StafType { get; set; }
        public string Comment { get; set; }
        public DateTime? DateAdded { get; set; }
        public int Status { get; set; }
        public string MedicalKnowledgeStrengths { get; set; }
        public string MedicalKnowledgeWeakness { get; set; }
        public string PatientCareStrengths { get; set; }
        public string PatientCareWeakness { get; set; }
        public string ProfessionalismStrengths { get; set; }
        public string ProfessionalismWeakness { get; set; }
        public bool IsResidentForDiscussion { get; set; }

        public Users Faculty { get; set; }
        public Group Group { get; set; }
        public Users Resident { get; set; }
        public ICollection<PassUserScoresItems> PassUserScoresItems { get; set; }
    }
}
