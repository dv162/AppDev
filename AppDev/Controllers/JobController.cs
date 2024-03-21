using Microsoft.AspNetCore.Mvc;

namespace AppDev.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
