using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.DTOs;

namespace DatingApp.API.Services
{
    public interface IMemberService
    {
        List<MemberDto> GetMembers();
        MemberDto GetMemberByUsername(string username);
        
    }
}