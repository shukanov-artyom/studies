using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace identity.Infrastructure
{
    /// <summary>
    /// Override IdentityUserClaim setting long as a primary key column type.
    /// </summary>
    public class ApplicationUserClaim : IdentityUserClaim<long>
    {
        // nothing here yet
    }
}