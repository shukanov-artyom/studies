using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class MyGroupsAndCategories
    {
        public int MyGroupsAndCategoriesId { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public int MembersCategoryId { get; set; }
        public DateTime? JoinedOn { get; set; }

        public Group Group { get; set; }
        public CategoryAttributes MembersCategory { get; set; }
        public Users User { get; set; }
    }
}
