using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class StudyPlanTypes
    {
        public StudyPlanTypes()
        {
            StudyPlan = new HashSet<StudyPlan>();
            StudyPlanSubTypes = new HashSet<StudyPlanSubTypes>();
        }

        public int StudyPlanTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<StudyPlan> StudyPlan { get; set; }
        public ICollection<StudyPlanSubTypes> StudyPlanSubTypes { get; set; }
    }
}
