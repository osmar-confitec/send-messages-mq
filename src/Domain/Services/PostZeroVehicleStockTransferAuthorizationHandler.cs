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
     /api/autorizacoes-transferencias-veiculo-zero-km Autorizar a transferência de um veículo zero km para um outro estabelecimento.
     
     */
    public class PostZeroVehicleStockTransferAuthorizationHandler : BaseIntegrationHandler<PostZeroVehicleStockTransferAuthorization>
    {
        public PostZeroVehicleStockTransferAuthorizationHandler(IServiceProvider serviceProvider, IMessageBus bus) : base(serviceProvider, bus)
        {
        }

        protected override Task ExecuteIntegrationEventAsync(PostZeroVehicleStockTransferAuthorization ev)
        {
            throw new NotImplementedException();
        }
        protected override string SetQuee() => string.Empty;
    }
}
