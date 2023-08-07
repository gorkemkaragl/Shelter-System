using Barinak_Sistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Barinak_Sistemi.Controllers
{
    public class DropAnimalController : Controller
    {
        private readonly dbContext _dbContext;
        public DropAnimalController(dbContext context)
        {
            _dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Process()
        {
            return View();
        }

        //Hayvan Kabul listesine hayvan ekleme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DropAnimal(DropAnimal animal)
        {

            if (ModelState.IsValid)
            {
                _dbContext.DAnimal.Add(animal);
                await _dbContext.SaveChangesAsync();
                ViewBag.SuccessMessage = "Hayvan bırakma işleminiz gerçekleşti";
                return View("Index", animal);

            }
            return View("Index");
        }


    }
}
