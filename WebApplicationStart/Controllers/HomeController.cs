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
            var res = DateTime.Now.Hour;
            if (res < 6)
                return "Ночь";
            if (res < 12)
                return "Утро";
            if (res < 18)
                return "День";
            return "Вечер";
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

        public string Task4(double a, double b, char c)
        {
            double res = 0;
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