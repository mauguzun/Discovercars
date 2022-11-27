using Discovercars.ApplicationServices.Interfaces.Request;

namespace DiscoverCars.ApplicationServices.Implementation.Request
{
    public class BaseService
    {
        protected readonly IRequestService _iRequestService;

        public BaseService(IRequestService iRequestService) => _iRequestService = iRequestService;
    }
}
