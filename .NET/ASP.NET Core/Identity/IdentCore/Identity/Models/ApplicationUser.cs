using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentCore.Identity.Models
{
    /// <summary>
    /// Overriding default Identity User class.
    /// Specifying long as its identifier (PK)
    /// </summary>
    public class ApplicationUser : IdentityUser<long, 
        ApplicationUserClaim, 
        ApplicationUserRole,
        ApplicationUserLogin>
    {
    }
}
