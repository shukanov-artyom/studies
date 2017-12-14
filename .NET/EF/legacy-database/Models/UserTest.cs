using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserTest
    {
        public UserTest()
        {
            Cme = new HashSet<Cme>();
            GroupsUserTests = new HashSet<GroupsUserTests>();
            PassGroupDefaultTest = new HashSet<PassGroupDefaultTest>();
            ProcedureSkillTest = new HashSet<ProcedureSkillTest>();
            ProductAndUserTestPermission = new HashSet<ProductAndUserTestPermission>();
            ProductLinkedTests = new HashSet<ProductLinkedTests>();
        }

        public string TestCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? TimeAllowed { get; set; }
        public int? TestType { get; set; }
        public string TestName { get; set; }
        public bool? UseRandomOrderForEveryUser { get; set; }
        public int? QuestionOrder { get; set; }
        public int TestCodeId { get; set; }
        public int? QuestionsCount { get; set; }
        public int UserTestExamTypeId { get; set; }
        public bool IsTwoWayExam { get; set; }
        public DateTime? DiscardedByOwnerOn { get; set; }
        public int SpecialtyId { get; set; }

        public Specialty Specialty { get; set; }
        public UserTestExamType UserTestExamType { get; set; }
        public ICollection<Cme> Cme { get; set; }
        public ICollection<GroupsUserTests> GroupsUserTests { get; set; }
        public ICollection<PassGroupDefaultTest> PassGroupDefaultTest { get; set; }
        public ICollection<ProcedureSkillTest> ProcedureSkillTest { get; set; }
        public ICollection<ProductAndUserTestPermission> ProductAndUserTestPermission { get; set; }
        public ICollection<ProductLinkedTests> ProductLinkedTests { get; set; }
    }
}
