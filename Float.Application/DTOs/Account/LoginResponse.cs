using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Application.DTOs.Account
{
   public class LoginResponse
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsVerified { get; set; }
    }
}
