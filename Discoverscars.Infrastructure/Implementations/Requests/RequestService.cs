using Discoverscars.Infrastructure.Interfaceses.Requests;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace Discoverscars.Infrastructure.Implementations.Requests
{
    public class RequestService : IRequestService
    {
        private readonly RestClient client;
        public RequestService(IConfiguration configuration)
        {
            var apiBaseUrl = configuration.GetValue<string>("ApiUrl");
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
