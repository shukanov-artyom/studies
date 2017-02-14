using System;
using identity.Persistency;
using Microsoft.AspNet.Identity;

namespace identity.Infrastructure
{
    public class ApplicationUserManagerFactory
    {
        public static ApplicationUserManager Create()
        {
            // Creating custom User Manager providing custom implementations of Identity Models.
            var userManager = new ApplicationUserManager(
                    new ApplicationUserStore(
                            new ApplicationDbContext()));
            userManager.UserValidator = new UserValidator<ApplicationUser, long>(userManager)
            {
                AllowOnlyAlphanumericUserNames = false,
            };
            return userManager;
        }
    }
}