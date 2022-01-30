using CrossCutting.MessageBus.IntegrationEvents;
using Domain.Interfaces;
using Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class RenaveService : BaseServiceHttp,  IRenaveService
    {

        readonly HttpClient _httpClient;

        public RenaveService(HttpClient httpClient)
            :base(httpClient)
        {
            _httpClient = httpClient;

        }

        public async Task<GetStockVehicleFitnessIntegrationResponse> GetStockVehicleFitnessAsync(GetStockVehicleFitnessIntegration getStockVehicleFitnessIntegration)
                  => await GetAsync<GetStockVehicleFitnessIntegrationResponse, GetStockVehicleFitnessIntegration>(getStockVehicleFitnessIntegration, "/api/aptidao-veiculo-estoque");
    }
}
