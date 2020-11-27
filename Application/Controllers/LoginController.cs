using Core.Entity;
using Microsoft.AspNetCore.Mvc;
using Service.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Controllers
{
    public class LoginController : Controller
    {
        private AuthService service;
        public LoginController(AuthService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            User user = service.AuthenticateUser(username, password);            

            return null;
        }
    }
}
