using Microsoft.AspNetCore.Mvc;

namespace PracticasASP.Controllers
{
	public class BeerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
