using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace IdentCore.Identity.Models
{
    public class ApplicationUserClaim : IdentityUserClaim<long>
    {
    }
}
