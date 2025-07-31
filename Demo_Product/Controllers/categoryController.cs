using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    [Authorize]
    public class categoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        public IActionResult Index()
        {
            var categories = categoryManager.TGetList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            categoryManager.TInsert(category);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            var category = categoryManager.TGetById(id);
            categoryManager.TDelete(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var category = categoryManager.TGetById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            categoryManager.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}
