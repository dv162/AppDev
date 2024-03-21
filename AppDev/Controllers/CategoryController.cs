using Microsoft.AspNetCore.Mvc;

namespace AppDev.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
