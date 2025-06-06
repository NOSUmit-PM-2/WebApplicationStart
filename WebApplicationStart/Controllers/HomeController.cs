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

         public string Task1()
        {
            int hour = DateTime.Now.Hour;
            if (hour >= 18)
            {
                return "Вечер";
            }
            else if (hour >= 12)
            {
                return "День";
            }
            else if (hour >= 6)
            {
                return "Утро";
            }
            else
            {
                return "Ночь";
            }
        }

        public string Task2(double id, double dopId)
        {
            return $"{id} + {dopId} = {id + dopId}";
        }
        public string Task3(int a, int b, char c)
        {
            int result = 0;
            switch (c)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (b == 0)
                        return "Дурак!";
                    result = a / b;
                    break;
                default:
                    return "Ошибка: неподдерживаемая операция.";
            }
            return $"{a}{c}{b}={result}";
        }
        public string Task4(int a, int b, char c)
        {
            int result = 0;
            switch (c)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (b == 0)
                        return "Дурак!";
                    return "Stupid";
                    result = a / b;
                default: return "stupid";
            }
            return "";
        }

        public IActionResult Tasks()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}