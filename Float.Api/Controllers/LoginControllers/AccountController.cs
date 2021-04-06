
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

        [HttpPost("api/v1/user/register")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterRequest model)
        {
            return Ok(await _accountService.RegisterAsync(model));
        }

        [HttpPost("api/v1/user/authenticate")]
        public async Task<IActionResult> AuthenticateUser([FromBody] LoginRequest model)
        {
            return Ok(await _accountService.AuthenticateAsync(model));
        }

        [HttpPut("api/v1/user/reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequest model)
        {
            return Ok(await _accountService.ResetPasswordAsync(model));
        }
    }
}
