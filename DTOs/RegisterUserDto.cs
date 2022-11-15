using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.DTOs
{
    public class RegisterUserDto
    {
        [Required]
        [MaxLength(256)]
        public string Username { get; set; }
        [Required]
        [MaxLength(256)]
        public string Password { get; set; }
        [Required]
        [MaxLength(256)]
        public string Email { get; set; }
       
        [Required]
        public DateTime DateOfBirth { get; set; }
 
        [Required]
        [MaxLength(32)]
        public string KnownAs { get; set; }
 
        [Required]
        [MaxLength(6)]
        public string Gender { get; set; }
 
        [Required]
        [MaxLength(32)]
        public string City { get; set; }
 
        [Required]
        [MaxLength(256)]
        public string Introduction { get; set; }
 
        [Required]
        [MaxLength(256)]
        public string Avatar { get; set; }
    }
}