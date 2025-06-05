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

        //задача 1
        public string Task1()
        {
            var Hour = DateTime.Now.Hour;

            if (Hour >= 0 && Hour < 6) return "Ночь";
            if (Hour >= 6 && Hour < 12) return "Утро";
            if (Hour >= 12 && Hour < 18) return "День";

            return "Вечер";
        }

        //задача 2
        public string Task2(int a, int b)
        {
            return Convert.ToString(a + b);
        }

        //решение задач 3 и 4
        public string Task3_4(int a, int b, string sign)
        {
            if (sign == "+") return Convert.ToString(a + b);
            if (sign == "-") return Convert.ToString(a - b);
            if (sign == "*") return Convert.ToString(a * b);
            if (sign == "/") return Convert.ToString(a / b);
            else return "Ошибочка";

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}