using Microsoft.AspNetCore.Mvc;

namespace HW.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
