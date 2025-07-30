using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class categoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
