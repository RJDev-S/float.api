using Float.Application.Interfaces;
using Float.Infrastracture.Persistence.Contexts;
using Float.Infrastracture.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Infrastracture.Persistence
{
    public static class ServiceExtension
    {
        public static void AddPersistenceInfrastracture(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
        }
    }
}
