using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo_Product.Controllers
{
    public class CustomerController : Controller
    {

        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        JobManager jobManager = new JobManager(new EfJobDal());
        public IActionResult Index()
        {
            var values = customerManager.GetCustomersListWithJob();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            var jobList = jobManager.TGetList()
                .Select(x => new SelectListItem
                {
                    Text = x.JobName,
                    Value = x.JobId.ToString()
                }).ToList();

            ViewBag.v = jobList;
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
            var jobList = jobManager.TGetList()
                .Select(x => new SelectListItem
                {
                    Text = x.JobName,
                    Value = x.JobId.ToString()
                }).ToList();

            ViewBag.v = jobList;
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