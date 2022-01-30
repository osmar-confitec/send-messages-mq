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
     Cliente Autenticado
    /api/cliente-autenticado Consultar os dados do cliente autenticado.
     */
    public class GetCustomerAuthenticateIntegrationHandler : BaseIntegrationHandler<GetCustomerAuthenticateIntegration>
    {
        public GetCustomerAuthenticateIntegrationHandler(IServiceProvider serviceProvider, IMessageBus bus)
                            : base(serviceProvider, bus)
        {
        }

        protected override Task ExecuteIntegrationEventAsync(GetCustomerAuthenticateIntegration ev)
        {
            throw new NotImplementedException();
        }

        protected override string SetQuee() => string.Empty;
    }
}
