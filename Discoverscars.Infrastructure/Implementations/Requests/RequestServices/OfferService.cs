using Discovercars.Domain.Entity;
using Discovercars.Domain.Requests;
using Discoverscars.Infrastructure.Interfaceses.Requests;
using Discoverscars.Infrastructure.Interfaceses.Requests.RequestServices;

namespace Discoverscars.Infrastructure.Implementations.Requests.RequestServices
{
    public class OfferService : BaseRequestServices, IOfferService
    {
        public OfferService(IRequestService iRequestService) : base(iRequestService) { }

        Task<IEnumerable<Offer>> IOfferService.Search(OfferRequest request)
        {
            return _requestService.Post<IEnumerable<Offer>, OfferRequest>("Availability/GetOffers", request);
        }
    }
}
