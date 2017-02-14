using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using identity.Infrastructure;
using identity.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security;

namespace identity.Controllers
{
    [AllowAnonymous]
    public class AuthController : ApplicationController
    {
        private readonly ApplicationUserManager userManager;

        public AuthController(ApplicationUserManager userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public ActionResult LogIn(string returnUrl)
        {
            var model = new LogInModel()
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> LogIn(LogInModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            ApplicationUser user = await userManager
                .FindAsync(model.Email, model.Password);
            if (user != null)
            {
                ClaimsIdentity identity = await userManager.CreateIdentityAsync(
                    user,
                    DefaultAuthenticationTypes.ApplicationCookie);
                GetAuthenticationManager().SignIn(identity);
                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }
            ModelState.AddModelError("", "Invalid email or password");
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            ApplicationUser user = new ApplicationUser()
            {
                UserName = model.Email,
                Country = model.Country,
                Age = model.Age
            };

            var registrationResult = await userManager.CreateAsync(user, model.Password);
            if (registrationResult.Succeeded)
            {
                await SignIn(user);
                return RedirectToAction("index", "home");
            }
            foreach (string error in registrationResult.Errors)
            {
                ModelState.AddModelError("", error);
            }
            return View();
        }

        public ActionResult LogOut()
        {
            var context = Request.GetOwinContext();
            var authManager = context.Authentication;
            authManager.SignOut(AuthenticationData.CookieName);
            return RedirectToAction("Index", "Home");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && userManager != null)
            {
                userManager.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// return url validation.
        /// </summary>
        private string GetRedirectUrl(string returnUrl)
        {
            if (String.IsNullOrEmpty(returnUrl) ||
                !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("index", "Home");
            }
            return returnUrl;
        }

        private IAuthenticationManager GetAuthenticationManager()
        {
            IOwinContext context = Request.GetOwinContext();
            IAuthenticationManager authManager = context.Authentication;
            return authManager;
        }

        private async Task SignIn(ApplicationUser user)
        {
            ClaimsIdentity identity = await userManager.CreateIdentityAsync(
                user,
                DefaultAuthenticationTypes.ApplicationCookie);
            GetAuthenticationManager().SignIn(identity);
        }
    }
}