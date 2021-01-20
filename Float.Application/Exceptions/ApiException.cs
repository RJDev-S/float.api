using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Application.Exceptions
{
   public class ApiException : Exception
    {
        public ApiException() : base()
        {

        }
        public ApiException(string message) : base(message)
        {

        }
    }
}
