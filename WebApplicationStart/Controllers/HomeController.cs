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
            int time = DateTime.Now.Hour;
            if (time >= 18)
                return "Добоый Вечер";
            if (time >= 12)
                return "Добоый День";
            if (time >= 6)
                return "Добоое Утро";
            return "Добоой Ночи";
        }
        public string Task2(double a, double b)
        {
            return $"{a} + {b} = {a + b}";
        }

        public string Task3(double a, double b, string op = "+")
        {
            switch (op)
            {
                case "+": return $"{a} + {b} = {a + b}";
                case "-": return $"{a} - {b} = {a - b}";
                case "*": return $"{a} * {b} = {a * b}";
                default: return $"В качестве пятого сегмента необходимо передать одну из желаемых операций (+, -, *)";
            }
        }

        public string Task4(double a, double b, string op = "+")
        {
            switch (op)
            {
                case null:
                case "+": return $"{a} + {b} = {a + b}";
                case "-": return $"{a} - {b} = {a - b}";
                case "*": return $"{a} * {b} = {a * b}";
                case "/": if (b != 0) return $"{a} / {b} = {a / b}"; else return "Делить на 0 нельзя ";
                default: return $"В качестве третьего параметра запроса необходимо передать одну из желаемых операций (+, -, *, /)";
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}