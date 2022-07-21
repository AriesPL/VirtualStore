using Microsoft.AspNetCore.Mvc;

namespace VirtualStore.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
