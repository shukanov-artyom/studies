using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProductAndVideoCategoryTypePermission
    {
        public int ProductAndVideoCategoryTypePermissionId { get; set; }
        public int ProductId { get; set; }
        public int CategoryTypeId { get; set; }

        public CategoryType CategoryType { get; set; }
        public Product Product { get; set; }
    }
}
