using Microsoft.AspNetCore.Mvc;
using VirtualStore.Models;

namespace VirtualStore.Controllers
{
	public class EmployeesController : Controller
	{
		private static readonly List<Employee> employees = new()
		{
			new Employee{Id = 1,Name = "Alex",SecondName = "Sergeev", Age = 33},
			new Employee{Id = 2,Name = "Natalya",SecondName = "Sergeeva", Age = 62},
			new Employee{Id = 3,Name = "Andrey",SecondName = "Sergeev", Age = 39},
		};

		public IActionResult Index()
		{
			var result = employees;
			return View(result);
		}
	}
}
