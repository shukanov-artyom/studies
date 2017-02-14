using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace identity.Infrastructure
{
    /// <summary>
    /// It adds application-specific claims to a claims collection when creating it.
    /// (Presumably on User login)
    /// Takes user-specific data data from user instance.
    /// </summary>
    public class ApplicationClaimsIdentityFactory : ClaimsIdentityFactory<ApplicationUser, long>
    {
        public override async Task<ClaimsIdentity> CreateAsync(
            UserManager<ApplicationUser, long> userManager,
            ApplicationUser user, 
            string authenticationType)
        {
            ClaimsIdentity identity = await base.CreateAsync(
                userManager, 
                user, 
                authenticationType);
            
            // Add custom claims here.
            identity.AddClaim(new Claim(ClaimTypes.Country, user.Country));
            identity.AddClaim(new Claim(ClaimTypes.Email, user.UserName));

            //something is converted to claims, something is left in 
            // ApplicationUser domain object.

            return identity;
        }
    }
}