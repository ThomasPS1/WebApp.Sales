using Microsoft.AspNetCore.Mvc;
using WebApp.Sales.Models;

namespace WebApp.Sales.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee
            {
                Id = 100,
                Name = "Thomas",
                Age = 22
            };
            return View(employee);
        }
        public IActionResult Details()
        {
            return View();
        }
       }
}
