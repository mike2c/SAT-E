using Application.ViewModel;
using Application.Security;
using Core.Security;
using Data.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entity;

namespace Application.Controllers
{
    public class AuthenticateController : Controller
    {
        private UserManager userManager;
        private SATContext dbContext;
        private IEncryptor encryptor;

        public AuthenticateController(SATContext dbContext, IEncryptor encryptor)
        {
            this.dbContext = dbContext;
            this.encryptor = encryptor;
            this.userManager = new UserManager(dbContext, encryptor);
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                if (HttpContext.User.IsInRole("Soporte de sistemas"))
                {
                    return RedirectToAction("Index", "TechnicalAssistance");
                }
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                await userManager.Authenticate(HttpContext, login.Username, login.Password);

                if (string.IsNullOrEmpty(returnUrl))
                    return RedirectToAction("Index", "TechnicalAssistance");
                else
                    return Redirect(returnUrl);
                
            }

            return View();
        }

        [Authorize]
        [HttpGet]
        public new async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("LogIn");
        }

    }
}
