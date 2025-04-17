using Microsoft.AspNetCore.Mvc;
using WebApp.Sales.Data;
using WebApp.Sales.Models;

namespace WebApp.Sales.Controllers
{
    public class SalesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var salesList = _context.Sales.ToList(); // fetches from SQL Server
            return View(salesList);
        }

        public IActionResult Details() //juuij
        {
            return View();

        }
        
       }
}
