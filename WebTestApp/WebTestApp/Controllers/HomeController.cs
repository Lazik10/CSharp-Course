using Microsoft.AspNetCore.Mvc;
using WebTestApp.Models;

namespace WebTestApp.Controllers
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
