using Float.Core.Dto;
using Float.Core.Interfaces;
using Float.Core.Model;
using Float.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Float.Api.Controllers.LoginControllers
{
    [ApiController]

    public class SignupController : Controller
    {
        private readonly ISignupService _signupService;
            
        public SignupController(ISignupService signupService)
        {
            _signupService = signupService;
        }

        [HttpGet("api/v1/get/signup")]
        public async Task<IActionResult> GetSignup([FromBody] SignupDto signup)
        {
            dynamic result;

            try
            {
                 result = await _signupService.AddUserinDb(signup);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}
