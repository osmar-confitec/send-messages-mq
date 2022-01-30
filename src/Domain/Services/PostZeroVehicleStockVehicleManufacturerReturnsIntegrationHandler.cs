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
    /api/devolucoes-montadora-veiculo-zero-km
Devolver veículo zero km para montadora.
     */
    public class PostZeroVehicleStockVehicleManufacturerReturnsIntegrationHandler : BaseIntegrationHandler<PostZeroVehicleStockVehicleManufacturerReturnsIntegration>
    {
        public PostZeroVehicleStockVehicleManufacturerReturnsIntegrationHandler(IServiceProvider serviceProvider, IMessageBus bus) : base(serviceProvider, bus)
        {

        }

        protected override Task ExecuteIntegrationEventAsync(PostZeroVehicleStockVehicleManufacturerReturnsIntegration ev)
        {
            throw new NotImplementedException();
        }

        protected override string SetQuee() => string.Empty;
    }
}
