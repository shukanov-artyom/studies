using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Specialty
    {
        public Specialty()
        {
            CategoryType = new HashSet<CategoryType>();
            Efootprint = new HashSet<Efootprint>();
            Focusheading = new HashSet<Focusheading>();
            Level = new HashSet<Level>();
            PassProfEval = new HashSet<PassProfEval>();
            PassProfScore = new HashSet<PassProfScore>();
            PaymentPeriods = new HashSet<PaymentPeriods>();
            PostNote = new HashSet<PostNote>();
            Procedure = new HashSet<Procedure>();
            ProcedureSkillStepNote = new HashSet<ProcedureSkillStepNote>();
            Rating = new HashSet<Rating>();
            Subspecialty = new HashSet<Subspecialty>();
            TestQuestionNote = new HashSet<TestQuestionNote>();
            TopicNote = new HashSet<TopicNote>();
            UserAndDisabledQuestionCriteria = new HashSet<UserAndDisabledQuestionCriteria>();
            UserTest = new HashSet<UserTest>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int? Sortorder { get; set; }
        public bool? Active { get; set; }
        public int WebsiteId { get; set; }

        public Website Website { get; set; }
        public ICollection<CategoryType> CategoryType { get; set; }
        public ICollection<Efootprint> Efootprint { get; set; }
        public ICollection<Focusheading> Focusheading { get; set; }
        public ICollection<Level> Level { get; set; }
        public ICollection<PassProfEval> PassProfEval { get; set; }
        public ICollection<PassProfScore> PassProfScore { get; set; }
        public ICollection<PaymentPeriods> PaymentPeriods { get; set; }
        public ICollection<PostNote> PostNote { get; set; }
        public ICollection<Procedure> Procedure { get; set; }
        public ICollection<ProcedureSkillStepNote> ProcedureSkillStepNote { get; set; }
        public ICollection<Rating> Rating { get; set; }
        public ICollection<Subspecialty> Subspecialty { get; set; }
        public ICollection<TestQuestionNote> TestQuestionNote { get; set; }
        public ICollection<TopicNote> TopicNote { get; set; }
        public ICollection<UserAndDisabledQuestionCriteria> UserAndDisabledQuestionCriteria { get; set; }
        public ICollection<UserTest> UserTest { get; set; }
    }
}
