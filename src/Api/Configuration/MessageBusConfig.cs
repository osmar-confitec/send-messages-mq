using CrossCutting.MessageBus;
using Domain.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Configuration
{
    public static class MessageBusConfig
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddMessageBus(configuration.GetMessageQueueConnection("MessageBus"))
               // .AddHostedService<GetAuthorizationsTransfersIntegrationHandler>()
                //.AddHostedService<GetCRLVElectronicIntegrationHandler>()
                .AddHostedService<GetStockVehicleFitnessIntegrationHandler>()
                //.AddHostedService<PostAuthorizationsTransfersIntegrationHandler>()
               // .AddHostedService<PostCancellationTransferAuthorizationsIntegrationHandler>()
                ;
        }
    }
}
