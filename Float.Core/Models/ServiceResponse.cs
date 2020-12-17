using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Core.Models
{
   public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
