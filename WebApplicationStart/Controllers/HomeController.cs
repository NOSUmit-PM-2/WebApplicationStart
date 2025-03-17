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
            string res = "1 задача:";
            DateTime dateTime = DateTime.Now;
            if (0 < dateTime.Hour && dateTime.Hour < 6)
                res += "Ночь";
            else if (6 < dateTime.Hour && dateTime.Hour < 12)
                res += "Утро";
            else if (12 < dateTime.Hour && dateTime.Hour < 18)
                res += "День";
            else if (18 < dateTime.Hour && dateTime.Hour < 24)
                res += "Ночь";
            return res;
        }

        public string Task2(int a, int b)
        {
            return $"{a}+{b}={a + b}";
        }

        public string Task3(int a, int b, char c)
        {
            int res = 0;
            switch (c)
            {
                case '+':
                    res = a + b;
                    break;
                case '-':
                    res = a - b;
                    break;
                case '*':
                    res = a * b;
                    break;
                case '/':
                    if (b == 0)
                        return "введите b, не равное 0";
                    res = a / b;
                    break;
                default:
                    return "Ошибка";
            }
            return $"{a}{b}{c}={res}";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}