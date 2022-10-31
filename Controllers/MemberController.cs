using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Controllersace;
using DatingApp.API.DTOs;
using DatingApp.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    
    [Route("api/members")]
    public class MemberController : BaseController
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet("get-list-member")]
        public ActionResult<List<MemberDto>> Get()
        {
            return Ok(_memberService.GetMembers());
        }

        [HttpGet("get-user-by/{username}")]
        public ActionResult<MemberDto> Get(string username)
        {
            return Ok(_memberService.GetMemberByUsername(username));
        }
    }
}