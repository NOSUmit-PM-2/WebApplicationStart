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
            int hours = DateTime.Now.Hour;
            if (hours < 6)
                return "Доброй ночи";
            if (hours < 12)
                return "Доброе утро";
            if (hours < 18)
                return "Добрый день";
            else
                return "Добрый вечер";
        }

        public string Task2(double a, double b)
        {
            return $"{a + b}";
        }
        public string Task3(double a, double b, string c="+")
        {
            return c switch
            {
                "+" => (a + b).ToString(),
                "*" => (a * b).ToString(),
                "-" => (a - b).ToString(),
                _ => "Ошибочная операция"
            } ;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}