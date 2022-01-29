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
        CRLV eletrônico
        [Get] /api/crlve/{placaVeiculo}/{renavamVeiculo} Consultar PDF do último CRLVe do veículo.
     */
    public class GetCRLVElectronicIntegrationHandler : BaseIntegrationHandler<GetCRLVElectronicIntegration>
    {
        public GetCRLVElectronicIntegrationHandler(IServiceProvider serviceProvider, IMessageBus bus) 
            : base(serviceProvider, bus)
        {
        }

        protected override string SetQuee()
        {
            throw new NotImplementedException();
        }

        protected override Task ExecuteIntegrationEventAsync(GetCRLVElectronicIntegration ev)
        {
            throw new NotImplementedException();
        }
    }
}
