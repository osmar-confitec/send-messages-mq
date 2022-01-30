using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CrossCutting;

namespace Domain.Services
{

    public class ErrorServer
    {
        public DateTime?  DataHora { get; set; }
        public string Detalhe { get; set; }
        public string MensagemParaUsuarioFinal { get; set; }
        public string Titulo { get; set; }

    }
    public abstract  class BaseServiceHttp
    {
        readonly HttpClient _httpClient;
        protected BaseServiceHttp(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        protected StringContent GetContent(object dado)
        {
            return new StringContent(
                JsonSerializer.Serialize(dado),
                Encoding.UTF8,
                "application/json");
        }
        protected async Task<T> DeserializeObjectResponse<T>(HttpResponseMessage responseMessage)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<T>(await responseMessage.Content.ReadAsStringAsync(), options);
        }


        protected async Task<TResp> PostAsync<TResp, TReq>(TReq req, string url)
        {
            var content = GetContent(req);

            var response = await _httpClient.PostAsync(url, content);
            TreatErrorsResponse(response);
            return await DeserializeObjectResponse<TResp>(response);
        }

        protected async Task<TResp> GetAsync<TResp, TReq>(TReq req, string url) where TResp : class where TReq : class
        {

            HttpResponseMessage response = new HttpResponseMessage();

            if (req != null)
                response = await _httpClient.GetAsync($"{url}?{req.GetQueryString(false)}");
            else
                response = await _httpClient.GetAsync($"{url}");

            TreatErrorsResponse(response);
            return await DeserializeObjectResponse<TResp>(response);
        }

        protected async Task<TResp> DeleteAsync<TResp, TReq>(TReq req, string url) where TResp : class where TReq : class
        {

            HttpResponseMessage response = new HttpResponseMessage();

            if (req != null)
                response = await _httpClient.DeleteAsync($"{url}?{req.GetQueryString(false)}");
            else
                response = await _httpClient.DeleteAsync($"{url}");

            TreatErrorsResponse(response);
            return await DeserializeObjectResponse<TResp>(response);
        }

        protected async Task<TResp> PutAsync<TResp, TReq>(TReq req, string url)
        {
            var content = GetContent(req);
            var response = await _httpClient.PutAsync(url, content);
            TreatErrorsResponse(response);

            return await DeserializeObjectResponse<TResp>(response);
        }

        protected bool TreatErrorsResponse(HttpResponseMessage response)
        {
           
            response.EnsureSuccessStatusCode();
            return true;
        }


    }
}
