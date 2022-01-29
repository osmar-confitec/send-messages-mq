using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Configuration
{
    public static class MySqlConfig
    {
        public static void AddSql(this IServiceCollection services,
        IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<Contexto>(options =>
                 options.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString), (x) => { x.EnableRetryOnFailure(); })
                 .EnableSensitiveDataLogging()
                 .UseLazyLoadingProxies()
                 );
        }
    }
}
