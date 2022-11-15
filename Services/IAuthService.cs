using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data.Entities;
using DatingApp.API.DTOs;

namespace DatingApp.API.Services
{
    public interface IAuthService
    {
        string Login(AuthUserDto authUserDto);
        string Register(RegisterUserDto registerUserDto);
    }
}