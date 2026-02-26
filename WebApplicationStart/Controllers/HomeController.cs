using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
            int hour = DateTime.Now.Hour;
            if (hour < 6)
            {
                return "Доброй ночи";
            }
            if (hour < 12)
            {
                return "Доброе утро";
            }
            if (hour < 18)
            {
                return "Добрый день";
            }
            return "Добрый вечер";
        }

        [Route("calculator/index/{n1?}/{n2?}")]
        public string Task2(int n1 = 0, int n2 = 0)
        {
            return $"{n1} + {n2} = {n1 + n2}";
        }

        [Route("calculator/index/{n1?}/{n2?}/{oper?}")]
        public string Task3(double n1 = 0, double n2 = 0, string oper = "+")
        {
            double res = 0;
            switch (oper)
            {
                case "+": res = n1 + n2; break;
                case "-": res = n1 - n2; break;
                case "*": res = n1 * n2; break;
                case "/": res = n1 / n2; break;
                default: return "Ошибка: Некорректная операция. Допустимые операции: +, -, *\rПример корректного запроса: https://localhost:7299/calculator/index/1/3/+";
            }
            return $"{n1} {oper} {n2} = {res}";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}