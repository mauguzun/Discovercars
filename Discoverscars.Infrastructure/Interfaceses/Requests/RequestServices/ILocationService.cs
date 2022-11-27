using Discovercars.Domain.Entity;

namespace Discoverscars.Infrastructure.Interfaceses.Requests.RequestServices
{
    public interface ILocationService
    {
        public Task<IEnumerable<Location>> GetAllAsync();
    }
}
