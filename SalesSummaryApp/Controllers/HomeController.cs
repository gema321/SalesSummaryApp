using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesSummaryApp.Data;
using System.Threading.Tasks;

namespace SalesSummaryApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SalesSummary()
        {
            var summaries = await _context.SalesSummaries.ToListAsync();
            return Json(new { status = "OK", items = summaries });
        }
    }
}
