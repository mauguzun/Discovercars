using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Discovercars.Api.Controllers
{
    public class ErrorController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            return Content(context?.Error.Message.ToString() ?? "Error ");
        }

    }
}