using Discovercars.ApplicationServices.Interfaces.Request;
using Discovercars.ApplicationServices.Interfaces.Request.RequestServices;
using Discovercars.Domain.Entity;
using Discovercars.Domain.Requests;

namespace DiscoverCars.ApplicationServices.Implementation.Request.RequestServices
{
    public class OfferService : BaseService, IOfferService
    {
        public OfferService(IRequestService iRequestService) : base(iRequestService) { }

        Task<IEnumerable<Offer>> IOfferService.Search(OfferRequest request)
        {
           return _iRequestService.Post<IEnumerable<Offer>, OfferRequest>("Availability/GetOffers", request);
        }
    }
}
