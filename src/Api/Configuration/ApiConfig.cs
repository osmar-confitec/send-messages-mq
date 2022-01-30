

using Data.Uow;
using Domain.Interfaces;
using Domain.Repository;
using Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Configuration
{
    public static class ApiConfig
    {

        public static IServiceCollection AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();

            /*Cors*/

            services.AddCors(options => {

                options.AddPolicy("development", builder => {
                    builder.AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowAnyOrigin();
                });

                options.AddPolicy("production", builder => {
                    builder.AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowAnyOrigin();
                });

            });
            /*Repository*/
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            


            services.AddHttpClient<IRenaveService, RenaveService>(http => {
                http.BaseAddress = new Uri(configuration.GetSection("RenaveUrl").Value);
            });
            return services;
        }


        public static IApplicationBuilder UseApiConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors("development");
            }
            else {
                app.UseCors("production");
            }
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            return app;
        }
    }
}
