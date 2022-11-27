using Discovercars.Domain.Entity;
using Discovercars.Domain.Requests;

namespace Discoverscars.Infrastructure.Interfaceses.Requests.RequestServices
{
    public interface IReservationService
    {
        public Task<Reservation> MakeReservation(ReservationRequest resevationRequest);
    }
}
