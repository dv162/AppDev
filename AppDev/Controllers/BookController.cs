using Microsoft.AspNetCore.Mvc;

namespace AppDev.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
