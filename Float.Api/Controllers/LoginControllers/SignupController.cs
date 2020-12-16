using Float.Core.Model;
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
        SignupModel _signupModel = new SignupModel();


        public SignupController()
        {

        }

        [HttpGet("api/v1/get/signup")]
        public IActionResult GetSignup()
        {
            return Ok(_signupModel);
        }
    }
}
