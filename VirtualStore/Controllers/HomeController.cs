using Microsoft.AspNetCore.Mvc;
using VirtualStore.Models;

namespace VirtualStore.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Result()
		{
			return Content("Hi");
		}
	}
}
