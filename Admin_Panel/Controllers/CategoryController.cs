using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
