using Float.Infrastracture.Identity.Context;
using Float.Infrastracture.Identity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Float.Application.Interfaces;
using Float.Application.Services.AccountServices;

namespace Float.Infrastracture.Identity
{
    public static class ServiceExtension
    {
        public static void AddIdentityInfrastracture(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(config.GetConnectionString("IdentityConnection"),
                b => b.MigrationsAssembly(typeof(IdentityContext).Assembly.FullName)));

            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<IdentityContext>();

            services.Configure<IdentityOptions>(options => 
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            });

            services.AddTransient<IAccountService, AccountService>();
        }
    }
}
