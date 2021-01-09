using AutoMapper;
using Float.Application.Interfaces;
using Float.Application.Services.AccountServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Float.Application
{
    public static class ServiceExtension
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(ISignupService), typeof(SignupService));
        }
    }
}
