using Discoverscars.Infrastructure.Interfaceses.Requests;

namespace Discoverscars.Infrastructure.Implementations.Requests.RequestServices
{
    public class BaseRequestServices
    {
        protected readonly IRequestService _iRequestService;

        public BaseRequestServices (IRequestService iRequestService) => _iRequestService = iRequestService;
    }
}
