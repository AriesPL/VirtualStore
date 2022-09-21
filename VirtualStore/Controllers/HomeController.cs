using Microsoft.AspNetCore.Mvc;

namespace VirtualStore.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Error()
		{
			return View();
		}

		public IActionResult Cart()
        {
			return View();
        }
		
		public IActionResult ContactUs()
        {
			return View();
        }
	}
}
