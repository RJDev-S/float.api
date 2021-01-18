using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Application.Exceptions
{
   public class APIException : Exception
    {
        public APIException() : base()
        {

        }
        public APIException(string message) : base(message)
        {

        }
    }
}
