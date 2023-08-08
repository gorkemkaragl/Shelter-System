using Barinak_Sistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Barinak_Sistemi.Controllers
{
	public class ShelterFormController : Controller
	{
        private readonly dbContext _dbContext;
        public ShelterFormController(dbContext context)
        {
            _dbContext = context;

        }
        public IActionResult Index()
        {
            ViewBag.SuccessMessage = "";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ShelterUsers shelterUsers)
        {
            if (ModelState.IsValid)
            {
                _dbContext.SUser.Add(shelterUsers);
                await _dbContext.SaveChangesAsync();
                ViewBag.SuccessMessage = "Hayvan sahiplenme isteği gönderildi";
                return View("Index", shelterUsers);
            }
            return View();
        }
    }
}

