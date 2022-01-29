using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Configuration
{
    public static class NativeInjectorBootStrapper
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services,
                    IConfiguration configuration)
        {
            /*
            services.AddScoped<IUserApplication, UsersApplication>();
            services.AddScoped<IMenuApplication, MenuApplication>();
            */

            return services;
        }
    }
}
