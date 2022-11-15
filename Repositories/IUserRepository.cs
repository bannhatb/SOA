using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data.Entities;

namespace DatingApp.API.Repositories
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUserById(int id);
        User GetUserByUsername(string username);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        bool IsSaveChanges();
    }
}