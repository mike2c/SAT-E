using Application.ViewModel;
using Core.Entity;
using Data.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Controllers
{
    public class UserController : Controller
    {
        private SATContext context;

        public UserController(SATContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                Rol selectedRol = context.Roles.Find(1);

                User u = new User();
                u.Email = user.Email;
                u.Password = user.Password;
                u.Username = user.Username;
                u.Email = user.Email;
                u.Rol = selectedRol;
                u.IsActive = true;

                context.Users.Add(u);
                context.SaveChanges();
            }

            return View(user);
        }
    }
}
