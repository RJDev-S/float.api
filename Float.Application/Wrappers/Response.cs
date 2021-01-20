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
            IsSuccess = true;
            Data = data;
            Message = message;
        }

        public Response(string message)
        {
            IsSuccess = false;
            Message = message;
        }

        public T Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }

    }
}
