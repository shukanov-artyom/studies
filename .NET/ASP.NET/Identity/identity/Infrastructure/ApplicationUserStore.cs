using System;
using identity.Persistency;
using Microsoft.AspNet.Identity.EntityFramework;

namespace identity.Infrastructure
{
    /// <summary>
    /// Custom implementation of the IUserStore Identity abstraction.
    /// -------
    /// Base class is taken from Microsoft.Aspnet.Identity.EntityFramework
    /// and provides all-ready implemenation for all interfaces, 
    /// required EF Data Context, thus EF-bound.
    /// </summary>
    public class ApplicationUserStore : UserStore<ApplicationUser,
        ApplicationRole,
        long,
        ApplicationUserLogin,
        ApplicationUserRole,
        ApplicationUserClaim>
    {
        /// <summary>
        /// IUserStore abstraction implemenation requires 
        /// - DB Context with appropriate schema and 
        /// - POCO classes for identity models (possibly subclasses)
        /// </summary>
        /// <param name="context"></param>
        public ApplicationUserStore(ApplicationDbContext context)
            : base(context)
        {
        }
    }

}