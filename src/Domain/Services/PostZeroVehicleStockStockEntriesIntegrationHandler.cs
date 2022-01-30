using CrossCutting.MessageBus;
using CrossCutting.MessageBus.IntegrationEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class PostZeroVehicleStockStockEntriesIntegrationHandler 
            : BaseIntegrationHandler<PostZeroVehicleStockStockEntriesIntegration>
    {
        public PostZeroVehicleStockStockEntriesIntegrationHandler(IServiceProvider serviceProvider, IMessageBus bus) : base(serviceProvider, bus)
        {
        }

        protected override Task ExecuteIntegrationEventAsync(PostZeroVehicleStockStockEntriesIntegration ev)
        {
            throw new NotImplementedException();
        }
        protected override string SetQuee() => string.Empty;
    }
}
