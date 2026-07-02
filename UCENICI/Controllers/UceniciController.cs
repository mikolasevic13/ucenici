using Microsoft.AspNetCore.Mvc;
using UCENICI.Models;

namespace UCENICI.Controllers
{
    public class UceniciController : Controller
    {
        public IActionResult Index()
        {
            var ucenici=UceniciRepository.GetUcenici(loadRazred:true);
            return View(ucenici);
        }
    }
}
