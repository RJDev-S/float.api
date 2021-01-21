using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Application.Wrappers
{
    public class Response<T>
    {
        public Response()
        {

        }

        public Response(T data, string message = null)
        {
            Data = data;
            Message = message;
            Succeeded = true;

        }

        public Response(string message, bool succeeded = false)
        {
            Succeeded = succeeded;
            Message = message;
        }

        public T Data { get; set; }
        public string Message { get; set; }
        public bool Succeeded { get; set; }
        public List<string> Errors { get; set; }

    }
}
