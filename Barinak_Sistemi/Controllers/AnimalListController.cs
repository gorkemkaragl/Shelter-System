using Microsoft.AspNetCore.Mvc;

namespace Barinak_Sistemi.Controllers
{
	public class AnimalListController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
