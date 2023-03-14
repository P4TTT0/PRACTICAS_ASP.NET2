using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PracticasASP.Models;

namespace PracticasASP.Controllers
{
	public class BeerController : Controller
	{
		private readonly PubContext _context;

		public BeerController(PubContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var beers = _context.Beers.Include(b => b.Brand);
			return View(await beers.ToListAsync());
		}

		public IActionResult Create()
		{
			ViewData["Brands"] = new SelectList(_context.Brands, "BrandId", "Name");
			return View();
		}

		[HttpPost]
		public IActionResult Create(int a)
		{
			ViewData["Brands"] = new SelectList(_context.Brands, "BrandId", "Name");
			return View();
		}
	}
}
