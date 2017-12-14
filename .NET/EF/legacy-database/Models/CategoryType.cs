using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CategoryType
    {
        public CategoryType()
        {
            Group = new HashSet<Group>();
            Post = new HashSet<Post>();
            ProductAndVideoCategoryTypePermission = new HashSet<ProductAndVideoCategoryTypePermission>();
            Video = new HashSet<Video>();
        }

        public int CategoryTypeId { get; set; }
        public string CategoryTypeName { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsForGroup { get; set; }
        public bool? IsForCase { get; set; }
        public bool? IsForVideo { get; set; }
        public bool? IsForPost { get; set; }
        public int SpecialtyId { get; set; }

        public Specialty Specialty { get; set; }
        public ICollection<Group> Group { get; set; }
        public ICollection<Post> Post { get; set; }
        public ICollection<ProductAndVideoCategoryTypePermission> ProductAndVideoCategoryTypePermission { get; set; }
        public ICollection<Video> Video { get; set; }
    }
}
