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

namespace Application.Controllers
{
    public class LoginController : Controller
    {
        private UserManager userManager;
        private SATContext dbContext;
        private IEncryptor encryptor;

        public LoginController(SATContext dbContext, IEncryptor encryptor)
        {
            this.dbContext = dbContext;
            this.encryptor = encryptor;
            this.userManager = new UserManager(dbContext, encryptor);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            if(HttpContext.User.Identity.IsAuthenticated)
                return RedirectToAction("NeedAuth");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                await userManager.Authenticate(HttpContext, login.Username, login.Password);
                return RedirectToAction("NeedAuth");
            }

            return View();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("LogIn");
        }

        [Authorize]
        public IActionResult NeedAuth()
        {
            return View();
        }

        [Authorize(Roles = "Redes")]
        public string Network()
        {
            return "Pagina privada de redes";
        }

        [Authorize(Roles = "Soporte")]
        public string Support()
        {
            return "Pagina privada de soporte";
        }
    }
}
