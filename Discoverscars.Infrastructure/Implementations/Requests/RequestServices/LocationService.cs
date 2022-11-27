using Discovercars.Domain.Entity;
using Discoverscars.Infrastructure.Interfaceses.Requests;
using Discoverscars.Infrastructure.Interfaceses.Requests.RequestServices;

namespace Discoverscars.Infrastructure.Implementations.Requests.RequestServices
{
    public class LocationService : BaseRequestServices , ILocationService
    {
        public LocationService(IRequestService iRequestService) : base(iRequestService) { }

        public async Task<IEnumerable<Location>> GetAllAsync()
        {
            return await _iRequestService.GetAsync<IEnumerable<Location>>("Locations/Locations");
        }

    }
}
