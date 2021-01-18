
using Float.Application.DTOs.Account;
using Float.Application.Interfaces;
using Float.Application.Wrappers;
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
        private readonly IAccountService _accountService;
            
        public AccountController(IAccountService signupService)
        {
            _accountService = signupService;
        }

        //[HttpGet("api/v1/get/signup")]
        //public async Task<IActionResult> GetSignup( )
        //{
        //    dynamic result;
        //    try
        //    {
        //        result = await _accountService.CreateUserAccount(new RegisterRequest());
        //        return Ok(result);
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }
        //}


        [HttpPost("api/v1/post/register")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterRequest register)
        {
            return Ok(await _accountService.RegisterAsync(register));
        }
    }
}
