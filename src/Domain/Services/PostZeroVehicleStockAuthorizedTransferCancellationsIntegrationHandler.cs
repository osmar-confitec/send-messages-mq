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
     Estoques de veículos zero km
    /api/cancelamentos-autorizacoes-transferencias-veiculo-zero-km Cancelar uma autorização de transferência de um veículo zero km para um outro estabelecimento.
     */
    public class PostZeroVehicleStockAuthorizedTransferCancellationsIntegrationHandler : BaseIntegrationHandler<PostZeroVehicleStockAuthorizedTransferCancellationsIntegration>
    {
        public PostZeroVehicleStockAuthorizedTransferCancellationsIntegrationHandler(IServiceProvider serviceProvider, IMessageBus bus) : base(serviceProvider, bus)
        {
        }

        protected override Task ExecuteIntegrationEventAsync(PostZeroVehicleStockAuthorizedTransferCancellationsIntegration ev)
        {
            throw new NotImplementedException();
        }
        protected override string SetQuee() => string.Empty;
    }
}
