using Microsoft.AspNetCore.Mvc;
using MVCRandomNuber.Models;

namespace MVCRandomNuber.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Generator generator = new Generator();
            ViewBag.Number = generator.GetNumber();

            return View();
        }
    }
}
