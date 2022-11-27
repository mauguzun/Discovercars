using Discoverscars.Infrastructure.Interfaceses.Requests.RequestServices;
using Microsoft.AspNetCore.Mvc;

namespace Discovercars.Api.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index([FromServices] ILocationService locationService)
        {
            var locations = await locationService.GetAllAsync();
            return View(locations);
        }

    }
}