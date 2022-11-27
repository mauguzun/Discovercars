using Discovercars.ApplicationServices.Interfaces.Request;
using Discovercars.ApplicationServices.Interfaces.Request.RequestServices;
using Discovercars.Domain.Entity;

namespace DiscoverCars.ApplicationServices.Implementation.Request.RequestServices
{
    public class LocationService : BaseService , ILocationService
    {
        public LocationService(IRequestService iRequestService) : base(iRequestService) {  }

        public async Task<IEnumerable<Location>> GetAllAsync()
        {
            return await _iRequestService.GetAsync<IEnumerable<Location>>("Locations/Locations");
        }

    }
}
