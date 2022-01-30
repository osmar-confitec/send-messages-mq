using CrossCutting.MessageBus;
using CrossCutting.MessageBus.IntegrationEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class PostZeroVehicleStockVehicleRejectionCancellationIntegrationHandler 
                : BaseIntegrationHandler<PostZeroVehicleStockVehicleRejectionCancellationIntegration>
    {
        public PostZeroVehicleStockVehicleRejectionCancellationIntegrationHandler(IServiceProvider serviceProvider, IMessageBus bus) : base(serviceProvider, bus)
        {
        }

        protected override Task ExecuteIntegrationEventAsync(PostZeroVehicleStockVehicleRejectionCancellationIntegration ev)
        {
            throw new NotImplementedException();
        }

        protected override string SetQuee() => string.Empty;
    }
}
