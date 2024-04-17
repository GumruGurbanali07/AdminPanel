using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Admin_Panel.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryManager cm;

        public CategoryController(EFCategoryDAL eFCategoryDAL)
        {
            cm = new CategoryManager(eFCategoryDAL);
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
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
            ValidationResult results=category.Validate(p);
            if(results.IsValid) {
                cm.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
