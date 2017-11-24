using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace IdentCore.Identity.Models
{
    /// <summary>
    /// Overriding default identity role class.
    /// </summary>
    public class ApplicationRole : IdentityRole<long>
    {
    }
}
