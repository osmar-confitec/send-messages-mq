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
     Cancelamento de autorizações de transferências
    [Post] /api/cancelamentos-autorizacoes-transferencias Cancelar uma Autorização de transferência de um veículo para um outro estabelecimento.

     */
    public class PostCancellationTransferAuthorizationsIntegrationHandler : BaseIntegrationHandler<PostCancellationTransferAuthorizationsIntegration>
    {
        public PostCancellationTransferAuthorizationsIntegrationHandler(IServiceProvider serviceProvider, IMessageBus bus) : base(serviceProvider, bus)
        {
        }

        protected override Task ExecuteIntegrationEventAsync(PostCancellationTransferAuthorizationsIntegration ev)
        {
            throw new NotImplementedException();
        }

        protected override string SetQuee() => string.Empty;
    }
}
