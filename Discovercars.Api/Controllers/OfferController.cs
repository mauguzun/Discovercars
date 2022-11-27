using Discovercars.Domain.Requests;
using Discoverscars.Infrastructure.Interfaceses.Requests.RequestServices;
using Microsoft.AspNetCore.Mvc;

namespace Discovercars.Api.Controllers
{
    public class OfferController : Controller
    {
        private readonly IOfferService _offerService;
        public OfferController(IOfferService offerService) => _offerService = offerService;

        [Route("[controller]/[action]/{locationId:int}")]
        public async Task<IActionResult> Index(int locationId)
        {
            var offers = await _offerService.Search(new OfferRequest(locationId));
            return View(offers);
        }


    }
}