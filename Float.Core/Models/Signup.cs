using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Core.Model
{
   public class Signup
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Passwords { get; set; }
        public string DateCreated { get; set; } = DateTime.Now.ToString();
        public string Type { get; set; } = "Local";
    }
}
