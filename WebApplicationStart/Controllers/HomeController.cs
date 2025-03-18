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
            int date = DateTime.Now.Hour;
            if (date >= 0 && date < 6) return "Доброй ночи";
            if (date >= 6 && date < 12) return "Доброе утро";
            if (date >= 12 && date < 18) return "Добрый день";
            return "Добрый вечер";
        }

        public string calculator(double a, double b=0)
        {
            return $"{a} + {b} = {a + b}";
            
        }

        public string calculatorpro(double a = 0, double b = 0, char c = '+')
        {

            switch(c)
                {
                case '+': return $"{a} + {b} = {a + b}";
                case '-': return $"{a} - {b} = {a - b}";
                case '*': return $"{a} * {b} = {a * b}";
                default: return "Проверь, верно ли ты все ввел?";
                }
            

        }
        public string calculatorparametrs(double a = 0, double b = 0, char c = '+')
        {

            switch (c)
            {
                case '+': return $"{a} + {b} = {a + b}";
                case '-': return $"{a} - {b} = {a - b}";
                case '*': return $"{a} * {b} = {a * b}";
                case '/': return b == 0 ? $"{a} / {b} = {a / b}" : "А ты уверен, что можно днли ть на 0?" ;
                default: return "Проверь, верно ли ты все ввел?";
            }


        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}