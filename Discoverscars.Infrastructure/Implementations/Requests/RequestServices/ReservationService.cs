using Discovercars.Domain.Entity;
using Discovercars.Domain.Requests;
using Discoverscars.Infrastructure.Interfaceses.Requests;
using Discoverscars.Infrastructure.Interfaceses.Requests.RequestServices;

namespace Discoverscars.Infrastructure.Implementations.Requests.RequestServices
{
    public class ReservationService : BaseRequestServices, IReservationService
    {
        public ReservationService(IRequestService iRequestService) : base(iRequestService) { }

        public Task<Reservation> MakeReservation(ReservationRequest resevationRequest)
        {
            return _requestService.Send<Reservation, ReservationRequest>("Reservations/CreateReservation", resevationRequest);
        }
    }
}
