using CrossCutting.MessageBus;
using CrossCutting.MessageBus.IntegrationEvents;
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

        protected override string SetQuee()
        {
            throw new NotImplementedException();
        }

        protected override Task ExecuteIntegrationEventAsync(GetStockVehicleFitnessIntegration ev)
        {
            throw new NotImplementedException();
        }
    }
}
