using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Tasks()
        {
            return View();
        }

        public string Task1()
        {
            int hour = DateTime.Now.Hour;
            if (hour < 6)
            {
                return "Доброй ночи";
            }
            if (hour < 12)
            {
                return "Доброе утро";
            }
            if (hour < 18)
            {
                return "Добрый день";
            }
            return "Добрый вечер";
        }

        [Route("calculator/index/{n1?}/{n2?}")]
        public string Task2(int n1 = 0, int n2 = 0)
        {
            return $"{n1} + {n2} = {n1 + n2}";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}