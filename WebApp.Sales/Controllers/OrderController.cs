using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Sales.Data;
using WebApp.Sales.Models;

namespace WebApp.Sales.Controllers
{
    public class OrderController : Controller

    {
        private ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            //List<Customers> customerList = new List<Customers>();
            var ordlst = _context.order.ToList();
            var orderList = _context.order.Include(x => x.Customer).ToList();
            return View(orderList);
        }
        public IActionResult Details(int id)
        {
            var custom = _context.order.Find(id);
            return View(custom);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult Create(Order ordlst)
        {
            _context.order.Add(ordlst);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var person = _context.order.Find(id);

            _context.order.Remove(person);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var customerList = _context.order.Find(id);
            return View(customerList);
        }


        [HttpPost]
        public IActionResult Edit(Order ordlst)
        {
            _context.order.Update(ordlst);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }

    
}
