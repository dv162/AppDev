using Microsoft.AspNetCore.Mvc;

namespace AppDev.Models
{
    public class Job : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
