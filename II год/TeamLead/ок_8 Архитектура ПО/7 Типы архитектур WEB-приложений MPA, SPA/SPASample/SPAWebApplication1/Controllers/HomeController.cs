using Microsoft.AspNetCore.Mvc;
using SPAWebApplication1.Models;

namespace SPAWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1001, "AAA", 32));
            employees.Add(new Employee(1002, "BBB", 31));
            employees.Add(new Employee(1003, "CCC", 30));
            return View(employees);
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
