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

    /*
     Autorizações de transferências

    /api/autorizacoes-transferencias
            Consultar autorizações de transferência. Se não informar nenhum parâmetro de pesquisa, serão retornadas todas as autorizações relacionadas com o estabelecimento solicitante.
     */
    public class GetAuthorizationsTransfersIntegrationHandler : BaseIntegrationHandler<GetAuthorizationsTransfersIntegration>
    {
        public GetAuthorizationsTransfersIntegrationHandler(IServiceProvider serviceProvider, IMessageBus bus)
                    : base(serviceProvider, bus)
        {


        }

        protected override Task ExecuteIntegrationEventAsync(GetAuthorizationsTransfersIntegration ev)
        {
            throw new NotImplementedException();
        }

        protected override string SetQuee()
        {
            throw new NotImplementedException();
        }
    }
}
