using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Admin_Panel.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryManager cm;

        public CategoryController(DbContextOptions<AppDbContext> options)
        {
            cm = new CategoryManager(options);
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryValues = cm.GetAll();
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
            cm.AddCategory(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}
