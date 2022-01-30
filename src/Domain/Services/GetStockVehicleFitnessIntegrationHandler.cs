using CrossCutting.MessageBus;
using CrossCutting.MessageBus.IntegrationEvents;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Services
{

    /*Aptidão de veículo para solicitação de entrada/saída em estoque*/
    /*[Get]/api/aptidao-veiculo-estoque Consultar aptidão de veículo para solicitação de entrada/saída em estoque.*/
    public class GetStockVehicleFitnessIntegrationHandler : BaseIntegrationHandler<GetStockVehicleFitnessIntegration>
    {
        public GetStockVehicleFitnessIntegrationHandler(IServiceProvider serviceProvider, IMessageBus bus)
                            : base(serviceProvider, bus)
        {


        }

        protected override string SetQuee() => string.Empty;

        protected override async Task ExecuteIntegrationEventAsync(GetStockVehicleFitnessIntegration ev)
        {
            using (var scope = _serviceProvider.CreateScope())
            {

                var renavanService = scope.ServiceProvider.GetRequiredService<IRenaveService>();
                /*faz a requisição*/
                var ret =  await renavanService.GetStockVehicleFitnessAsync(ev);

                /*grava na base*/
            }
        }
    }
}
