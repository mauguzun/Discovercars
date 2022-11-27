namespace Discovercars.ApplicationServices.Interfaces.Request
{
    public interface IRequestService
    {
        public Task<Tout> GetAsync<Tout>(string url);

        public Task<Tout> Post<Tout, Tin>(string url, Tin request);
    }
}
