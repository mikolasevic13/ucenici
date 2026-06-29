using Microsoft.AspNetCore.Mvc;
using UCENICI.Models;

namespace UCENICI.Controllers
{
    public class RazrediController:Controller
    {
        public IActionResult Index()
        {
            var razredi=RazrediRepository.GetRazredi();
            return View(razredi);
        }

        public IActionResult Edit(int? id)
        {
            var razred = RazrediRepository.GetRazredById(id.HasValue?id.Value:0);
            
            return View(razred);
        }
        [HttpPost]
        public IActionResult Edit(Razred razred)
        {
            RazrediRepository.UpdateRazred(razred.RazredId, razred);
            return RedirectToAction(nameof(Index));
        }
    }
}
