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
            DateTime currentTime = DateTime.Now;

            if (currentTime.Hour >= 5 && currentTime.Hour < 10)
                return "Утро";
            if (currentTime.Hour >= 10 && currentTime.Hour < 17)
                return "День";
            if (currentTime.Hour >= 17 && currentTime.Hour < 20)
                return "Вечер";
            return "Ночь";
        }

        public double Task2(double a = 0, double b = 0)
        {
            return a + b;
        }

        public string Task3(double a, double b, char operation = '+')
        {
            switch (operation)
            {
                case '+': return (a + b).ToString();
                case '-': return (a - b).ToString();
                case '*': return (a * b).ToString();
                case '/':
                    if (b == 0)
                    {
                        return "Ошибка: деление на ноль невозможно.";
                    }
                    return (a / b).ToString();
                default:
                    return "Пока что я умею выполнять только эти операции: '+', '-', '*', '/'";
            }
            //http://localhost:5090/Home/task3?a=5&b=3&operation=+ для проверки, можно поиграться
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}