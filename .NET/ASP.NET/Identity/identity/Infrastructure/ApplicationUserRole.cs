using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace identity.Infrastructure
{
    /// <summary>
    /// Override IdentityUserRole setting long as a primary key column type.
    /// </summary>
    public class ApplicationUserRole : IdentityUserRole<long>
    {

    }
}