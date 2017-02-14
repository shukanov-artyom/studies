using System;
using Microsoft.AspNet.Identity;

namespace identity.Infrastructure
{
    /// <summary>
    /// Custom implemenation of User Manager.
    /// Uses long Id column instead of default string.
    /// </summary>
    public class ApplicationUserManager : UserManager<ApplicationUser, long>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser, long> store)
            : base(store)
        {
            // Setting out own ClaimsIdentityFactory
            // To set up Claims using User object data.
            ClaimsIdentityFactory = new ApplicationClaimsIdentityFactory();
            // PasswordHasher = new PasswordHasher(); Can override IPasswordHasher 
        }
    }
}