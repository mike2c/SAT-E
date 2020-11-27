using Core.Entity;
using Data.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Service.Auth
{
    public class AuthService : Service
    {
        public AuthService(SATContext context) : base(context)
        {
        }

        public User AuthenticateUser(string username, string password)
        {

            username = username.ToLower();            
            User user = context.Users.Single(u => u.Username.ToLower().Equals(username) && u.Password.Equals(password));

            return user;
        }
    }
}
