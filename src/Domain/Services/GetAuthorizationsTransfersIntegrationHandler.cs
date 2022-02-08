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

        protected override async Task ExecuteIntegrationEventAsync(GetAuthorizationsTransfersIntegration ev)
        {
            using (var scope = _serviceProvider.CreateScope())
            {

                var renavanService = scope.ServiceProvider.GetRequiredService<IRenaveService>();
                /*faz a requisição*/
                //var ret = await renavanService.GetAuthorizationsTransfersAsync(ev);

                /*grava na base*/
            }
        }

        protected override string SetQuee() => string.Empty;
    }
}
