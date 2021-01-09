
using Float.Application.DTOs.Account;
using Float.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Float.Api.Controllers.LoginControllers
{
    [ApiController]
    public class AccountController : Controller
    {
        private readonly ISignupService _signupService;
            
        public AccountController(ISignupService signupService)
        {
            _signupService = signupService;
        }

        [HttpPost("api/v1/get/signup")]
        public async Task<IActionResult> GetSignup([FromBody] UserAccountDTO signup)
        {
            dynamic result;

            try
            {
                result = await _signupService.AddUserinDb(signup);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
