using Discovercars.ApplicationServices.Interfaces.Request;
using Discovercars.ApplicationServices.Interfaces.Request.RequestServices;
using Discovercars.Domain.Entity;
using Discovercars.Domain.Requests;

namespace DiscoverCars.ApplicationServices.Implementation.Request.RequestServices
{
    public class ReservationService : BaseService, IReservationService
    {
        public ReservationService(IRequestService iRequestService) : base(iRequestService) { }

        public Task<Reservation> Add(ReservationRequest resevationRequest)
        {
            return _iRequestService.Post<Reservation, ReservationRequest>("Reservations/CreateReservation", resevationRequest);
        }
    }
}
