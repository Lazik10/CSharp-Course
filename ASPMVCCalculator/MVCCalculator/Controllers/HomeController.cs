using Microsoft.AspNetCore.Mvc;
using MVCCalculator.Models;

namespace MVCCalculator.Controllers
{
    public class HomeController : Controller
    {
/*        public IActionResult Index()
        {
            Calculator calculator = new Calculator();
            return View(calculator);
        }*/

        [HttpPost] // Sends values from form
        public IActionResult Index(Calculator calculator)
        {
            if (ModelState.IsValid)
            {
                calculator.Compute();
            }

            return View(calculator);
        }

        [HttpGet] // Gets value from url string
        public IActionResult Index(string name)
        {
            Calculator calculator = new Calculator();
            ViewBag.Name = name;

            return View(calculator);
        }
    }
}
