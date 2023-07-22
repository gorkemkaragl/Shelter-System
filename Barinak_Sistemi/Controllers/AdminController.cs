using Microsoft.AspNetCore.Mvc;

namespace Barinak_Sistemi.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
