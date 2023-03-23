using Discoverscars.Infrastructure.Interfaceses.Requests;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace Discoverscars.Infrastructure.Implementations.Requests
{
    public class RequestService : RestClient , IRequestService 
    {

        public RequestService(IConfiguration configuration) => this.Options.BaseUrl = new Uri(configuration.GetValue<string>("ApiUrl"));
  

        public async Task<Tout> GetAsync<Tout>(string url)
        {
            var httpRequest = new RestRequest(url, Method.Get);
            var queryResult = await this.ExecuteAsync<Tout>(httpRequest);

            return queryResult.Data;
        }

        public async Task<Tout> Send<Tout, Tin>(string url, Tin request)
        {

            var httpRequest = new RestRequest(url, Method.Post);
            httpRequest.RequestFormat = DataFormat.Json;
            httpRequest.AddBody(request);

            var queryResult = await this.ExecuteAsync<Tout>(httpRequest);

            return queryResult.Data;
        }
    }
}
