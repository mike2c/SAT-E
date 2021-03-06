﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
