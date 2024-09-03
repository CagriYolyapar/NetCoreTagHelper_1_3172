using Microsoft.AspNetCore.Mvc;

namespace NetCoreTagHelper_1.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult CreateCategory()
        {
            return View();
        }
    }
}
