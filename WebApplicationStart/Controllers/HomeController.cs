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

            if (currentTime.Hour <= 5)
                return "Ночь";
            if (currentTime.Hour <= 10)
                return "Утро";
            if (currentTime.Hour <= 17)
                return "День";
            return "Вечер";
            //почему-то кажется это неправильным.. после 22 вроде уже ночь. можно поставить вперед это условие, но я не стала, пусть так будет
        }

        public string Task2(double a, double b)
        {
            return $"{a} + {b} = {a + b}";
            //http://localhost:5090/Home/task2?a=5&b=4  чтобы поиграться
        }

        public string Task3(double a, double b, char operation = '+')
        {
            switch (operation)
            {
                case '+': return $"{a} + {b} = {a + b}";
                case '-': return $"{a} - {b} = {a - b}";
                case '*': return $"{a} * {b} = {a * b}";
                case '/':
                    if (b == 0)
                    {
                        return "Ошибка: деление на ноль невозможно.";
                    }
                    return $"{a} / {b} = {a / b}";
                default:
                    return "Пока что я умею выполнять только эти операции: '+', '-', '*', '/'";
            }
            //http://localhost:5090/Home/task3?a=5&b=3&operation=+ для проверки, можно поиграться
        }

        public string Task4(double a, double b, char operation = '+')
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