using Barinak_Sistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Barinak_Sistemi.Controllers
{
	public class AnimalListController : Controller
	{
        private readonly dbContext _dbContext;

        public AnimalListController(dbContext context)
        {
            _dbContext = context;


        }
        public IActionResult Index()
		{
            ViewData["Animals"] = _dbContext.Animals.ToList();
            List<Animal> animals = _dbContext.Animals.ToList();
            return View(animals);
            
		}
    }
}
