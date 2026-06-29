using Microsoft.AspNetCore.Mvc;

namespace UCENICI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

    }
}
