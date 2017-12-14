using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CategoryAttributes
    {
        public CategoryAttributes()
        {
            MyGroupsAndCategories = new HashSet<MyGroupsAndCategories>();
        }

        public int CategoryAttributeId { get; set; }
        public int GroupId { get; set; }
        public string CategoryName { get; set; }
        public int? Position { get; set; }
        public int? RoleBucketId { get; set; }
        public DateTime? ResidencyCompletionTargetDate { get; set; }
        public int? ResidencyStartYear { get; set; }
        public int? ResidencyCompletionTargetYear { get; set; }

        public Group Group { get; set; }
        public ICollection<MyGroupsAndCategories> MyGroupsAndCategories { get; set; }
    }
}
