using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class CalcController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CalcController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public string Index(double a = 0, double b = 0, string c = "+")
        {
            if (b == 0 && c == "/")
                return "На ноль делить нельзя!";
            switch (c)
            {
                case "+": return $"{a} + {b} = {a + b}";
                case "-": return $"{a} - {b} = {a - b}";
                case "*": return $"{a} * {b} = {a * b}";
                case "/": return $"{a} / {b} = {a / b}";
                default: return "неверный знак, попробуйте снова";
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}