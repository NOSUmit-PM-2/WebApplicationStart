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
            string timee = "Задача №1 - ";
            DateTime dateTime = DateTime.Now;
            if (0 < dateTime.Hour && dateTime.Hour < 6)
                timee += "Ночь";
            else if (6 < dateTime.Hour && dateTime.Hour < 12)
                timee += "Утро";
            else if (12 < dateTime.Hour && dateTime.Hour < 18)
                timee += "День";
            else if (18 < dateTime.Hour && dateTime.Hour < 24)
                timee += "Ночь";
            return timee;
        }
        public string Task2(int a, int b)
        {
            return $"{a}+{b}={a + b}";
        }

        public string Task3(double a = 0, double b = 0, char op = '+')
        {
            switch (op)
            {
                case '+': return $"{a} + {b} = {a + b}";
                case '-': return $"{a} - {b} = {a - b}";
                case '*': return $"{a} * {b} = {a * b}";
                default:
                    return "Операция недоступна.\nМожно ввести только '+', '-' и '*'";
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}