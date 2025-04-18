using Microsoft.AspNetCore.Mvc;
using Oblig1_261667.Models;
using Oblig1_261667.Services;

namespace Oblig1_261667.Controllers
{
    public class SpillController : Controller
    {
        private readonly SpillService _spillService;

        public SpillController()
        {
            _spillService = new SpillService();
        }

        public IActionResult Index()
        {
            var spill = _spillService.HentSpill();
            return View("Spill");
        }

        public IActionResult SpillTrekk(int ruteId)
        {
            _spillService.FjernRute(ruteId);

            if (_spillService.AlleRuterFjernet())
            {
                ViewBag.SpillFerdig = true;
            }

            var spill = _spillService.HentSpill();
            return View("Spill");
        }

        [HttpPost]
        public IActionResult StartPåNytt()
        {
            _spillService.StartNyttSpill();
            return RedirectToAction("Index");
        }
    }
}
