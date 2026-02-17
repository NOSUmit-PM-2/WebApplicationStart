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
            var time = DateTime.Now;
            if (time.Hour < 6)
            {
                return "Доброй ночи";
            }
            if (time.Hour < 12) { 
                return "Доброе утро";
            }
            if (time.Hour< 18){
                return "Добрый день";
            }
            return "Добрый вечер";


        }
        public string Task2(int num1 = 0, int num2 = 0)
        {
            return $"{num1} + {num2} = {num1 + num2}" ;


        }
        public string Task3(int num1 = 0, int num2 = 0, string op = "+")
        {
            switch(op)
            {
                case "+": return $"{num1} + {num2} = {num1 + num2}";
                case "-": return $"{num1} - {num2} = {num1 - num2}";
                case "*": return $"{num1} * {num2} = {num1 * num2}";
                default: return $"Введите корректную операцию(+,-,*)";
            }
        }
        public string Task4(int a = 0, int b = 0, string c = "+")
        {
            switch (c)
            {
                case "+": return $"{a} + {b} = {a + b}";
                case "-": return $"{a} - {b} = {a - b}";
                case "*": return $"{a} * {b} = {a * b}";
                case "/": if (b == 0) { return "На ноль делить нельзя"; } return $"{a} * {b} = {a * b}";
                default: return $"Введите корректную операцию(+,-,*)";
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}