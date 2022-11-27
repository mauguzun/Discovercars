using Discovercars.ApplicationServices.Interfaces.Request;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace DiscoverCars.ApplicationServices.Implementation.Request
{
    public class RequestService : IRequestService
    {
        private readonly RestClient client;
        public RequestService(IConfiguration configuration)
        {
            string apiBaseUrl = configuration["apiKey"];
            client = new RestClient(apiBaseUrl);
        }

        public async Task<Tout> GetAsync<Tout>(string url)
        {
            var httpRequest = new RestRequest(url, Method.Get);
            var queryResult = await client.ExecuteAsync<Tout>(httpRequest);

            return queryResult.Data;
        }

        public async Task<Tout> Post<Tout, Tin>(string url, Tin request)
        {
            var httpRequest = new RestRequest(url, Method.Post);
            httpRequest.RequestFormat = DataFormat.Json;
            httpRequest.AddBody(request);

            var queryResult = await client.ExecuteAsync<Tout>(httpRequest);

            return queryResult.Data;
        }
    }
}
