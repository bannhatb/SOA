using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.DTOs
{
    public class AuthUserDto
    {
        [Required]
        [MaxLength(256)]
        public string Username { get; set; }
        [Required]
        [MaxLength(256)]
        public string Password { get; set; }
        // [EmailAddress]
        // public string Email { get; set; }
    }

    public class AuthUserToken
    {
        public string Username { get; set; }
        public string Token { get; set; }
    }
}