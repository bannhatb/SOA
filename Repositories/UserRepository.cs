using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Data.Entities;

namespace DatingApp.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void CreateUser(User user)
        {
            _dataContext.Users.Add(user);
        }

        public void DeleteUser(User user)
        {
            _dataContext.Users.Remove(user);
        }

        public User GetUserById(int id)
        {
            return _dataContext.Users.FirstOrDefault(x => x.Id == id);
        }

        public User GetUserByUsername(string username)
        {
            return _dataContext.Users.FirstOrDefault(x => x.Username == username);
        }

        public List<User> GetUsers()
        {
            return _dataContext.Users.ToList();
        }

        public void UpdateUser(User user)
        {
            _dataContext.Users.Update(user);
        }
        public bool IsSaveChanges()
        {
            return _dataContext.SaveChanges() > 0;
        }

    }
}