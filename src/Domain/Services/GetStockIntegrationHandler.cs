using CrossCutting.MessageBus;
using CrossCutting.MessageBus.IntegrationEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    /*
     
     Estoques
    /api/estoques Consultar registro de estoque. Se não informar nenhum parâmetro de pesquisa, será retornado todo o estoque do estabelecimento.
     */
    public class GetStockIntegrationHandler : BaseIntegrationHandler<GetStockIntegration>
    {
        public GetStockIntegrationHandler(IServiceProvider serviceProvider, IMessageBus bus) 
            : base(serviceProvider, bus)
        {
        }

        protected override Task ExecuteIntegrationEventAsync(GetStockIntegration ev)
        {
            throw new NotImplementedException();
        }

        protected override string SetQuee() => string.Empty;
    }
}
