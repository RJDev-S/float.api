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
        public Response(int statusCode)
        {
            StatusCode = statusCode;
        }

        public Response(int statusCode, T data)
        {
            Data = data;
            StatusCode = statusCode;

        }

        //public Response(int statusCode)
        //{
        //    StatusCode = statusCode;
        //}

        public int StatusCode { get; set; }
        public T Data { get; set; }

    }
}
