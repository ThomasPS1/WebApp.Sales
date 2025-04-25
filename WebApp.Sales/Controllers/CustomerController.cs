using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Sales.Data;
using WebApp.Sales.Models;
using WebAppplication.Services.Repository;
namespace WebApp.Models
{
    [Authorize]
    public class CustomerController : Controller
    {
        
        private readonly IEmployeeRepository _repository;

        public CustomerController(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var customerList = await _repository.GetAllCustomerAsync();
            return View(customerList);
        }
        //public IActionResult Index()
        //{
        //    //List<Customers> customerList = new List<Customers>();
        //    var customerList = _context.Customer.ToList();
        //    return View(customerList);
        //}

        public async Task<IActionResult> Details(int id)
        {
            var custom = await _repository.GetCustomerByIdAsync(id);
            return View(custom);
        }
        //public IActionResult Details(int id)
        //{
        //    var custom = _context.Customer.Find(id);
        //    return View(custom);
        //}

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            await _repository.AddCustomerAsync(customer);
            return RedirectToAction("Index");
        }


        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Customer customerList)
        //{
        //    _context.Customer.Add(customerList);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}



        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteCustomerAsync(id);
            return RedirectToAction("Index");

        }
        //public IActionResult Delete(int id)
        //{
        //    var person = _context.Customer.Find(id);

        //    _context.Customer.Remove(person);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var customer = await _repository.GetCustomerByIdAsync(id);
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Customer customer)
        {
            await _repository.UpdateCustomerAsync(customer);
            return RedirectToAction("Index");
        }


        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    var customerList = _context.Customer.Find(id);
        //    return View(customerList);
        //}


        //[HttpPost]
        //public IActionResult Edit(Customer customerList)
        //{
        //    _context.Customer.Update(customerList);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}