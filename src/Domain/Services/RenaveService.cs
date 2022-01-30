using Domain.Interfaces;
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
    }
}
