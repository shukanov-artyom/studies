using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CmePostSurveyResults
    {
        public int UserId { get; set; }
        public int CmeId { get; set; }
        public DateTime? CompleteDate { get; set; }
        public int? Satisfaction { get; set; }
        public string SatisfactionComment { get; set; }
        public int? CommercialBias { get; set; }
        public string CommercialBiasComment { get; set; }
        public int? Objective { get; set; }
        public string ObjectiveComment { get; set; }
        public int? PersonalGoal { get; set; }
        public string ChangePracticeComment { get; set; }
        public string ContactName { get; set; }
        public string ContactDegree { get; set; }
        public double? AttestHours { get; set; }
        public bool ChangePracticeNothing { get; set; }
        public bool ChangePracticeEvaluation { get; set; }
        public bool ChangePracticeManagement { get; set; }
        public bool IsDraft { get; set; }
        public string PersonalGoalComment { get; set; }
        public bool ChangePracticeOther { get; set; }

        public Cme Cme { get; set; }
        public Users User { get; set; }
    }
}
