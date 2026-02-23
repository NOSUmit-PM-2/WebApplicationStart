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

        public string Task4(double a = 0, double b = 0, string c = "+")
        {
            double res = 0;
            if (c == "+")
            {
                res = a + b;
            }
            else if (c == "-")
            {
                res = a - b;
            }
            else if (c == "*")
            {
                res = a * b;
            }
            else if (c == "/")
            {
                if(b == 0)
                {
                    return "На ноль делить нельзя";
                }
                res = a / b;
            }
            else
            {
                return "Операция не поддерживается";
            }
            return $"{a} {c} {b} = {res}";
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}