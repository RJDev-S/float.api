using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Application.DTOs.Account
{
    public class ResetPasswordRequest
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public string NewPassword { get; set; }
    }
}
