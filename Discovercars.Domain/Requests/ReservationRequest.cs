using Discovercars.Domain.Entity;

namespace Discovercars.Domain.Requests
{
    public record ReservationRequest (string? OfferUid , Customer Customer) { }
}
