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
    public class LoginController : Controller
    {
		private readonly dbContext _dbContext;
		public LoginController(dbContext context)
		{
			_dbContext = context;
		}

		public IActionResult Index()
		{
			ViewBag.ErrorMessage = "";
			return View();	
		}

		//kullanıcı giriş kontrolü
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Index(string userEmail,string password)
        {
			foreach (var item in _dbContext.User)
			{
				//Console.WriteLine(item.userEmail);

				if (item.userEmail.ToString() == userEmail && item.password.ToString() == password)
				{
					if (item.userId == 1)
					{
						return RedirectToAction("AnimalList", "Admin");
					}

					
					return RedirectToAction("Index", "AnimalList");
				}
				else
				{
					ViewBag.ErrorMessage = "Hatalı email veya şifre."; 
				}
			}
			return View();
		}

		//kullanıcı kayıt olma
		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user)
        {
            
            if (ModelState.IsValid)
            {
                _dbContext.User.Add(user);
                await _dbContext.SaveChangesAsync();
				ViewBag.SuccessMessage = "Kayıt Oldunuz Lütfen Giriş Yapınız"; 
                return View("Index", user);
				
			}
            return View("Index");
        }

	}
}
