using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GigMusicHub.Models;
using Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.AspNet.Identity.Owin;

namespace GigMusicHub
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            //configure the db conetxt,userManager and SignIn Manager to use a single intance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            //Eanbel the Application to use cookie to store information for the signed in user
            //and to use cookie to temporarily store information about a user loggin in with third party login provider
            //Configure the sign in cookie
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType=DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath=new PathString("/Account/Login"),
                Provider=new CookieAuthenticationProvider
                {
                    //Enable the application to validate the security stamp when the user log in.
                    //this is a security feature which is used when you change a password or add an external login to your account
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
                        validateInterval:TimeSpan.FromMinutes(30),
                        regenerateIdentity:(manager,user)=>user.GenerateUserIdentityAsync(manager))
                        
                 }
            });
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);
            app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie);





















































        }
    }
}