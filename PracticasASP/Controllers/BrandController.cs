using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticasASP.Models;

namespace PracticasASP.Controllers
{
    public class BrandController : Controller
    {
        private readonly PubContext _context;

        public BrandController(PubContext context)
        {
            this._context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Brands.ToListAsync());
        }
    }
}
