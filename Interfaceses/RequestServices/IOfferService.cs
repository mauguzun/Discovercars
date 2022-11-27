using Discovercars.Domain.Entity;
using Discovercars.Domain.Requests;

namespace Discovercars.ApplicationServices.Interfaces.Request.RequestServices
{
    public interface IOfferService
    {
        public Task<IEnumerable<Offer>> Search(OfferRequest request);
    }
}
