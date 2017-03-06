using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentCore.Identity.Models
{
    /// <summary>
    /// Overriding default identity role class.
    /// </summary>
    public class ApplicationRole : IdentityRole<long, ApplicationUserRole, ApplicationRoleClaim>
    {
    }
}
