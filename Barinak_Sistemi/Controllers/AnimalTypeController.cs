using Microsoft.AspNetCore.Mvc;

namespace Barinak_Sistemi.Controllers
{
    public class AnimalTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
