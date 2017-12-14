using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class StudyPlanSubTypes
    {
        public StudyPlanSubTypes()
        {
            StudyPlan = new HashSet<StudyPlan>();
        }

        public int StudyPlanSubTypeId { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }

        public StudyPlanTypes Parent { get; set; }
        public ICollection<StudyPlan> StudyPlan { get; set; }
    }
}
