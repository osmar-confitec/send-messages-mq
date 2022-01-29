using CrossCutting.MessageBus;
using CrossCutting.MessageBus.IntegrationEvents;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{

    /*
    Autorizações de transferências
    /api/autorizacoes-transferencias Autorizar a transferência de um veículo para um outro estabelecimento.

     */
    public class PostAuthorizationsTransfersIntegrationHandler : BaseIntegrationHandler<PostAuthorizationsTransfersIntegration>
    {
        public PostAuthorizationsTransfersIntegrationHandler(IServiceProvider serviceProvider, IMessageBus bus) : base(serviceProvider, bus)
        {
        }

        protected override string SetQuee()
        {
            throw new NotImplementedException();
        }

        protected override Task ExecuteIntegrationEventAsync(PostAuthorizationsTransfersIntegration ev)
        {
            throw new NotImplementedException();
        }
    }
}
