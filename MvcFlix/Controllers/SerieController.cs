using Microsoft.AspNetCore.Mvc;

namespace MvcFlix.Controllers
{
    public class SerieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
