using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProductAndUserTestPermission
    {
        public int ProductAndUserTestPermissionId { get; set; }
        public int ProductId { get; set; }
        public string TestCode { get; set; }

        public Product Product { get; set; }
        public UserTest TestCodeNavigation { get; set; }
    }
}
