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
    /api/cancelamentos-entrada-estoque-zero-km Cancelar entrada de estoque de veículo zero km.
     */
    public class PostZeroVehicleStockInventoryCancellationsIntegrationHandler 
        : BaseIntegrationHandler<PostZeroVehicleStockInventoryCancellationsIntegration>
    {
        public PostZeroVehicleStockInventoryCancellationsIntegrationHandler(IServiceProvider serviceProvider, IMessageBus bus) : base(serviceProvider, bus)
        {
        }

        protected override Task ExecuteIntegrationEventAsync(PostZeroVehicleStockInventoryCancellationsIntegration ev)
        {
            throw new NotImplementedException();
        }

        protected override string SetQuee() => string.Empty;
    }
}
