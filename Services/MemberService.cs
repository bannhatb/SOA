using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.DTOs;

namespace DatingApp.API.Services
{
    public class MemberService : IMemberService
    {
        private readonly DataContext _dataContext;

        public MemberService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public MemberDto GetMemberByUsername(string username)
        {
            var user = _dataContext.Users.FirstOrDefault(x => x.Username == username);
            if (user == null) return null;
            return new MemberDto
            {
                Avatar = user.Avatar,
                City = user.City,
                CreateAt = user.CreateAt,
                DateOfBirth = user.DateOfBirth,
                Email = user.Email,
                Gender = user.Gender,
                Introduction = user.Introduction,
                KnownAs = user.KnownAs,
                Username = user.Username
            };
        }

        public List<MemberDto> GetMembers()
        {
            return _dataContext.Users.Select(user => new MemberDto
            {
                Avatar = user.Avatar,
                City = user.City,
                CreateAt = user.CreateAt,
                DateOfBirth = user.DateOfBirth,
                Email = user.Email,
                Gender = user.Gender,
                Introduction = user.Introduction,
                KnownAs = user.KnownAs,
                Username = user.Username
            }).ToList();
        }
    }
}