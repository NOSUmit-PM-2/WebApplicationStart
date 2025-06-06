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
            return "Тут решение первой задачи";
            int hour = DateTime.Now.Hour;
            if (hour >= 18)
            {
                return "Вечер";
            }
            else if (hour >= 12)
            {
                return "День";
            }
            else if (hour >= 6)
            {
                return "Утро";
            }
            else
            {
                return "Ночь";
            }
        }
        public string Task2(double a, double b)
        {
            return $"{a} + {b} = {a + b}";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}