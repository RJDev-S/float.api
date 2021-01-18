using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Float.Application
{
    public static class ServiceExtension
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
