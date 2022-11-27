using Discovercars.Domain.Entity;
using Discovercars.Domain.Requests;

namespace Discovercars.ApplicationServices.Interfaces.Request.RequestServices
{
    public interface IReservationService
    {
        public Task<Reservation> Add(ReservationRequest resevationRequest);
    }
}
