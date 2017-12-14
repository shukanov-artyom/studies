using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class QuestionSourceCategory
    {
        public QuestionSourceCategory()
        {
            Test = new HashSet<Test>();
        }

        public int QuestionSourceCategoryId { get; set; }
        public string Name { get; set; }
        public int SpecialtyId { get; set; }
        public bool? UiFilterApplicable { get; set; }
        public bool InTopicCounter1Applicable { get; set; }
        public bool InTopicCounter2Applicable { get; set; }
        public int DisplayOrder { get; set; }

        public ICollection<Test> Test { get; set; }
    }
}
