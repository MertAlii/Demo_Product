using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            ProductValidator validationRules = new ProductValidator();
            ValidationResult result = validationRules.Validate(product);
            if (result.IsValid)
            {
                productManager.TInsert(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        public IActionResult DeleteProduct(int id)
        {
            var values = productManager.TGetById(id);
            productManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = productManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            productManager.TUpdate(product);
            return RedirectToAction("Index");
        }
        
    }
}
