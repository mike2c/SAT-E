using Core.Entity;
using Core.Security;
using Data.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace Application.Security
{
    public class UserManager
    {
        private SATContext context;
        private IEncryptor encryptor;

        public UserManager(SATContext dbContext, IEncryptor encryptor)
        {
            this.context = dbContext;
            this.encryptor = encryptor;
        }

        public async System.Threading.Tasks.Task Authenticate(HttpContext httpContext, string username, string password)
        {

            User user = context.Users.Include(u => u.Rol).Where(u => u.Username.Equals(username) && u.Password.Equals(encryptor.encrypt(password))).FirstOrDefault();

            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Sid, user.UserId.ToString()),
                    new Claim(ClaimTypes.Surname, user.Username),
                    new Claim(ClaimTypes.Name, "Miguel Angel Castillo"),
                    new Claim(ClaimTypes.Email, user.Email)
                };

                claims.Add(new Claim(ClaimTypes.Role, user.Rol.RolName));

                //user.Rol.ForEach(rol => claims.Add(new Claim(ClaimTypes.Role, rol.RolName)));

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties props = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(360),
                    //RedirectUri = "http://Localhost/Home/Privacy"
                    RedirectUri = "~/asdfasfsdfasf"
                };

                await httpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    props);
            }            
        }
    }
}
