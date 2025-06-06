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

        public string Task4(double a = 0, double b = 0, char operation = '+')
        {
           // return "Тут решение четвертой задачи";
            string result;

            switch (operation)
            {
                case '+':
                    result = $"{a} + {b} = {a + b}";
                    break;
                case '-':
                    result = $"{a} - {b} = {a - b}";
                    break;
                case '*':
                    result = $"{a} * {b} = {a * b}";
                    break;
                case '/':
                    if (b != 0)
                        result = $"{a} / {b} = {a / b}";
                    else
                        result = "Ошибка: деление на ноль!";
                    break;
                default:
                    result = "Проверь, верно ли ты все ввел?";
                    break;
            }

            return result;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}