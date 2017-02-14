using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace identity.Infrastructure
{
    /// <summary>
    /// This class instances will be persisted to database.
    /// We apply a customization here in generic parameters,
    /// Setting Id to be long instead of default string.
    /// 
    /// It is a custom implemention of IUser Identity abstraction.
    /// </summary>
    public class ApplicationUser : IdentityUser<
        long, 
        ApplicationUserLogin, 
        ApplicationUserRole, 
        ApplicationUserClaim>
    {
        [Required]
        public string Country { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}