
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
        private readonly IAccountService _signupService;
            
        public AccountController(IAccountService signupService)
        {
            _signupService = signupService;
        }

        [HttpGet("api/v1/get/signup")]
        public async Task<IActionResult> GetSignup( )
        {
            dynamic result;
            try
            {
                result = await _signupService.CreateUserAccount(new UserAccountDTO());
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
