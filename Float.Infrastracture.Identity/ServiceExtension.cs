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

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            })
                .AddEntityFrameworkStores<IdentityContext>()
                .AddDefaultTokenProviders();


            services.AddTransient<IAccountService, AccountService>();
        }
    }
}
