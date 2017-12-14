using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProductAndGroupPermission
    {
        public int ProductAndGroupPermissionId { get; set; }
        public int ProductId { get; set; }
        public int GroupId { get; set; }

        public Group Group { get; set; }
        public Product Product { get; set; }
    }
}
