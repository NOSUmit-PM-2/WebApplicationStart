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
        }
         
        public string Task3(int num1 = 0, int num2 = 0, string op = "+")
        {
            var res = 0;
            if (op == "+")
            {
                res = num1 + num2;
            }
            else if (op == "-")
            {
                res = num1 - num2;
            }
            else if (op == "*")
            {
                res = num1 * num2;
            }
            else
            {
                return "Операция не поддерживается";
            }
            return $"{num1} {op} {num2} = {res}";
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}