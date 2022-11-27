using Discovercars.Domain.Requests;
using Discoverscars.Infrastructure.Interfaceses;
using Discoverscars.Infrastructure.Interfaceses.Requests.RequestServices;
using Microsoft.AspNetCore.Mvc;

namespace Discovercars.Api.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly INotificationService _notificationService;

        public ReservationController(IReservationService reservationService, INotificationService notificationService)
        =>
           (_reservationService, _notificationService) = (reservationService, notificationService);


        [HttpPost]
        public async Task<IActionResult> Index(ReservationRequest reservationRequest)
        {
            if (ModelState.IsValid)
            {
                var reservation = await _reservationService.MakeReservation(reservationRequest);
                if(reservation != null )
                {
                    await _notificationService.Notification(reservation);
                    return View(reservation);
                }
            }
            // show error , or other
            throw new Exception("Model not valid");
        }

    }
}
