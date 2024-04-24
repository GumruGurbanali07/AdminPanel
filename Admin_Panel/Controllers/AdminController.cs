using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel.Controllers
{
    public class AdminController : Controller
    {
        private readonly CategoryManager cm;
        private readonly ICategoryDAL _categoryDAL;

        public AdminController(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
            cm = new CategoryManager(_categoryDAL);
        }
        public IActionResult Index()
        {
            var categoryValues = cm.GetList();
            return View(categoryValues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            // cm.AddCategory(p);
            CategoryValidatior category = new CategoryValidatior();
            ValidationResult results = category.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
