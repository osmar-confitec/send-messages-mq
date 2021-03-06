using CrossCutting.MessageBus.IntegrationEvents;
using Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
   public  interface IRenaveService
    {

        Task<ObterAutorizacoesTransferenciasResponse> GetStockVehicleFitnessAsync(ObterAutorizacoesTransferenciasIntegration getStockVehicleFitnessIntegration);

       // Task<IEnumerable<ObterAutorizacoesTransferenciasIntegrationResponse>> GetAuthorizationsTransfersAsync(GetAuthorizationsTransfersIntegration getAuthorizationsTransfersIntegration);

    }
}
