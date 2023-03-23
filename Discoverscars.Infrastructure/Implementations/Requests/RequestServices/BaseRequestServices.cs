using Discoverscars.Infrastructure.Interfaceses.Requests;

namespace Discoverscars.Infrastructure.Implementations.Requests.RequestServices
{
    public class BaseRequestServices
    {
        protected readonly IRequestService _requestService;

        public BaseRequestServices (IRequestService rquestService) => _requestService = rquestService;
    }
}
