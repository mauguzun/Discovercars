using Discovercars.Domain.Entity;
using Discovercars.Domain.Requests;

namespace Discoverscars.Infrastructure.Interfaceses.Requests.RequestServices
{
    public interface IOfferService
    {
        public Task<IEnumerable<Offer>> Search(OfferRequest request);
    }
}
