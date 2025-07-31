using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    [Authorize]
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserName = User.Identity?.Name;
            return View();
        }
    }
}
