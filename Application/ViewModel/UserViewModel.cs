using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class UserViewModel
    {
        public int UserId { get; set; }        
        [Required]
        public string Username { get; set; }        
        [Required]
        public string Password { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public int RolId { get; set; }
    }
}
