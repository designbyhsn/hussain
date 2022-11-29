using Microsoft.AspNetCore.Mvc;

namespace Into_to_web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
