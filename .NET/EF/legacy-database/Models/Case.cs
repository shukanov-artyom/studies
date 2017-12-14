using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Case
    {
        public Case()
        {
            CaseImage = new HashSet<CaseImage>();
            CaseProcedure = new HashSet<CaseProcedure>();
            CaseShare = new HashSet<CaseShare>();
            CaseShareEmail = new HashSet<CaseShareEmail>();
            CaseShareGroup = new HashSet<CaseShareGroup>();
            CaseVideos = new HashSet<CaseVideos>();
            Comment = new HashSet<Comment>();
            ProductLinkedCases = new HashSet<ProductLinkedCases>();
            UserCaseTagged = new HashSet<UserCaseTagged>();
        }

        public int CaseId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string PatientId { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public DateTime? DateOfSurgery { get; set; }
        public string ChiefComplaint { get; set; }
        public string Hpi { get; set; }
        public string MedicalHistory { get; set; }
        public string PhysicalExam { get; set; }
        public int? PrivacySetting { get; set; }
        public string OperationPerformed { get; set; }
        public string Question { get; set; }
        public string Diagnosis { get; set; }
        public int? CategoryId { get; set; }
        public int? TopicId { get; set; }
        public int? ShareWith { get; set; }
        public DateTime? SharedOn { get; set; }
        public bool? SurgeryPending { get; set; }
        public bool HideName { get; set; }
        public bool? IsDeleted { get; set; }
        public string CaseGuid { get; set; }
        public string Outcome { get; set; }
        public string OperationPerformed2 { get; set; }
        public string OperationPerformed3 { get; set; }
        public int? QuestionId { get; set; }
        public DateTime? DateOfSurgery2 { get; set; }
        public DateTime? DateOfSurgery3 { get; set; }
        public int CaseStatusId { get; set; }
        public int? ProctorId { get; set; }
        public DateTime? CaseStatusDate { get; set; }
        public int SubspecialtyId { get; set; }

        public CaseStatus CaseStatus { get; set; }
        public Users CreatedByNavigation { get; set; }
        public Users Proctor { get; set; }
        public TestQuestion QuestionNavigation { get; set; }
        public Subspecialty Subspecialty { get; set; }
        public Topic Topic { get; set; }
        public ICollection<CaseImage> CaseImage { get; set; }
        public ICollection<CaseProcedure> CaseProcedure { get; set; }
        public ICollection<CaseShare> CaseShare { get; set; }
        public ICollection<CaseShareEmail> CaseShareEmail { get; set; }
        public ICollection<CaseShareGroup> CaseShareGroup { get; set; }
        public ICollection<CaseVideos> CaseVideos { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<ProductLinkedCases> ProductLinkedCases { get; set; }
        public ICollection<UserCaseTagged> UserCaseTagged { get; set; }
    }
}
