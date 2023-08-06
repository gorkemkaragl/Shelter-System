using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Barinak_Sistemi.Models;
using System.Data.Entity;

namespace Barinak_Sistemi.Controllers
{
	public class AdminController : Controller
	{

        private readonly dbContext _dbContext;

        public AdminController(dbContext context)
        {
            _dbContext = context;
            

        }

        public IActionResult Index()
        {
            
            ViewData["Users"] = _dbContext.User.Where(x => x.userId == 2).ToList();
            
            return View();
        }
        public IActionResult Users()
        {
            List<User> users = _dbContext.User.ToList();
            return View(users);
        }
        public IActionResult AnimalShelter()
		{
			return View();
		}
        public IActionResult DropAnimal()
        {
            return View();
        }

    }
}
