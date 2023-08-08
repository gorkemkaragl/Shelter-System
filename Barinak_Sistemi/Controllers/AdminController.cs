

using Barinak_Sistemi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barinak_Sistemi.Controllers
{
	public class AdminController : Controller
	{

        private readonly dbContext _dbContext;

        public AdminController(dbContext context)
        {
            _dbContext = context;
            

        }
        //kullanıcıları LİSTELEME
        public IActionResult Users()
        {
            List<User> users = _dbContext.User.ToList();
            return View(users);
        }
        public IActionResult AnimalShelter()
		{
            ViewData["ShelterUsers"] = _dbContext.SUser.ToList();
            List<ShelterUsers> shelterUsers = _dbContext.SUser.ToList();
            return View(shelterUsers);

		}

        // Hayvan Kabulde bekleyen hayvanları listeleme
        public IActionResult DropAnimal()
        {
            List<DropAnimal> dropAnimals = _dbContext.DAnimal.ToList();
            return View(dropAnimals);
        }
        
        //Hayvanları Listeleme
        public IActionResult AnimalList()
        {
			
			List<Animal> animals = _dbContext.Animals.ToList();
			return View(animals);
        }
        public IActionResult AddAnimalForm()
        {
            return View();
        }


        //Admin tarafından hayvan ekleme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAnimal(Animal animal)
        {

            if (ModelState.IsValid)
            {
                _dbContext.Animals.Add(animal);
                await _dbContext.SaveChangesAsync();
                ViewBag.SuccessMessage = "Başarılı bir şekilde eklendi";
                return View("AddAnimalForm", animal);

            }
            return View("AddAnimalForm");
        }

        public IActionResult AddNewUser()
        {
            return View();
        }
        //Admin tarafından kullanıcı ekleme
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUser(User users)
        {

            if (ModelState.IsValid)
            {
                _dbContext.User.Add(users);
                await _dbContext.SaveChangesAsync();
                ViewBag.SuccessMessage = "Başarılı bir şekilde eklendi";
                return View("AddNewUser", users);

            }
            return View("AddNewUser");
        }

        //Kullanıcı Silme İşlemleri
        public async Task<IActionResult> Delete(int id)
        {
            var users = await _dbContext.User.FirstOrDefaultAsync(m => m.userId == id);
            return View(users);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var users = await _dbContext.User.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }

            _dbContext.User.Remove(users);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Users", "Admin");
        }

        // Hayvan Silme İşlemleri
        public async Task<IActionResult> DeleteA(int id)
        {
            var animals = await _dbContext.Animals.FirstOrDefaultAsync(m => m.AnimalId == id);
            return View(animals);
        }

        [HttpPost, ActionName("DeleteA")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            var animals = await _dbContext.Animals.FindAsync(id);
            if (animals == null)
            {
                return NotFound();
            }

            _dbContext.Animals.Remove(animals);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("AnimalList", "Admin");
        }

        //Kullanıcı Edit işlemleri
        public async Task<IActionResult> EditUser(int? id)
        {
            if (id == null || _dbContext.User == null)
            {
                return NotFound();
            }

            var users = await _dbContext.User.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }
            return View(users);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(User users)
        {
            if (ModelState.IsValid)
            {

                _dbContext.Update(users);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction("Users", "Admin");
            }
            return View(users);
        }

        //Hayvan Edit işlemleri
        public async Task<IActionResult> EditAnimal(int? id)
        {
            if (id == null || _dbContext.Animals == null)
            {
                return NotFound();
            }

            var animal = await _dbContext.Animals.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }
            return View(animal);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAnimal(Animal animal)
        {
            if (ModelState.IsValid)
            {

                _dbContext.Update(animal);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction("AnimalList", "Admin");
            }
            return View(animal);
        }

    }
}
