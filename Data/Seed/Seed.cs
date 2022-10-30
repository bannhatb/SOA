using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using DatingApp.API.Data.Entities;
using System.Security.Cryptography;
using System.Text;

namespace DatingApp.API.Data.Seed
{
    public static class Seed
    {
        public static void SeedUsers(DataContext _dataContext)
        {
            if(_dataContext.Users.Any()) return ;

            var usersText = System.IO.File.ReadAllText("Data/Seed/users.json");

            var users = JsonSerializer.Deserialize<List<User>>(usersText);
            // var users = JsonConvert.DeserializeObject<List<User>>(usersText);

            // if(users == null) return;

            foreach (var user in users){
                using var hmac = new HMACSHA512();
                user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("123456"));
                user.PasswordSalt = hmac.Key;
                user.CreateAt = DateTime.Now;
                _dataContext.Users.Add(user);
            }
            _dataContext.SaveChanges();
        }
    }
}