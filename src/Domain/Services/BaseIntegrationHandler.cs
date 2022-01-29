using CrossCutting.MessageBus;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Services
{
    public abstract class BaseIntegrationHandler<T> : BackgroundService where T : IntegrationEvent
    {

        protected readonly IMessageBus _bus;
        protected readonly IServiceProvider _serviceProvider;
        protected string Quee; 

        protected BaseIntegrationHandler(IServiceProvider serviceProvider, IMessageBus bus)
        {
            _serviceProvider = serviceProvider;
            _bus = bus;
            Quee = SetQuee();
        }

        protected abstract string SetQuee();

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            SetSubscribers();
            return Task.CompletedTask;
        }

        private void SetSubscribers()
        {
            _bus.SubscribeAsync<T>(Quee, async request =>
                await ExecuteIntegrationEventAsync(request));
        }
        protected abstract Task ExecuteIntegrationEventAsync(T ev);
    }


}
