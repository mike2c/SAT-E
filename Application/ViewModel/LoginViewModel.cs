using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [MaxLength(45)]
        public string Password { get; set; }
        //public string Email { get; set; }

    }
}
