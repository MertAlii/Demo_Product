using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        public IActionResult Index()
        {
            var values = customerManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            customerManager.TInsert(customer);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCustomer(int id)
        {
            var values = customerManager.TGetById(id);
            customerManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var values = customerManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            customerManager.TUpdate(customer);
            return RedirectToAction("Index");
        }
    }
}