using Microsoft.AspNetCore.Mvc;

namespace Oblig1_261667.Controllers
{
    public class SpillController : Controller
    {
        public IActionResult Index()
        {
            return View("Spill");
        }
    }
}
