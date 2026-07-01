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
            if(ModelState.IsValid)
            {
                RazrediRepository.UpdateRazred(razred.RazredId, razred);
                return RedirectToAction(nameof(Index));
            }
            return View(razred);
            
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Razred razred)
        {
            if (ModelState.IsValid)
            {
                RazrediRepository.AddRazred(razred);
                return RedirectToAction(nameof(Index));
            }
            return View(razred);

        }

        [HttpGet]
        public IActionResult Delete(int razredId)
        {
            RazrediRepository.DeleteRazred(razredId);
            return RedirectToAction(nameof(Index));
        }
    }
}
