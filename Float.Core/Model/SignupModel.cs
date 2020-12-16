using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Core.Model
{
   public class SignupModel
    {
        public int ID { get; set; }
        public string Username { get; set; } = "Rj";
        public string Password { get; set; } = "1234";
        public string DateCreated { get; set; } = DateTime.Now.ToString();
        public string Type { get; set; } = "Local";
    }
}
