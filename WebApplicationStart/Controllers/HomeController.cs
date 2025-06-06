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
#pragma warning disable CS0162 // Обнаружен недостижимый код
            DateTime now = DateTime.Now;
#pragma warning restore CS0162 // Обнаружен недостижимый код
            int hour = now.Hour;
            if (hour >= 18) return "Вечер";
            else if (hour >= 12) return "День";
            else if (hour >= 6) return "Утро";
            else return "Ночь";
        }
        public string Task2(int a, int b)
        {
            return a + " + " + b + " = " + (a + b);
        }
        public string Task3()
        {
            int a = 10;
            int b = 5;
            char operation = '*';

            switch (operation)
            {
                case '+': return $"{a} + {b} = {a + b}";
                case '-': return $"{a} - {b} = {a - b}";
                case '*': return $"{a} * {b} = {a * b}";
                case '/':
                    if (b == 0) return "Ошибка: деление на ноль";
                    return $"{a} / {b} = {a / b}";
                default: return "Неизвестная операция";
            }
        }
        public string Task4(int a, int b, char operation)
        {
            switch (operation)
            {
                case '+': return $"{a} + {b} = {a + b}";
                case '-': return $"{a} - {b} = {a - b}";
                case '*': return $"{a} * {b} = {a * b}";
                case '/':
                    if (b == 0) return "Ошибка: деление на ноль";
                    return $"{a} / {b} = {a / b}";
                default: return "Неизвестная операция";
            }
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
