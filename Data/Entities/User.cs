using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Data.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Username { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [MaxLength(32)]
        public string KnownAs { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [MaxLength(6)]
        public string Gender { get; set; }
        [MaxLength(512)]
        public string Introduction { get; set; }
        [MaxLength(100)]
        public string Avatar { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

    }
}