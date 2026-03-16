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
            if (c == "+")
                return $"{a} + {b} = {a + b}";
            else if (c == "-")
                return $"{a} - {b} = {a - b}";
            else if (c == "*")
                return $"{a} * {b} = {a * b}";
            else if (c == "/")
            {
                if (b == 0)
                    return "На ноль делить нельзя!";
                else
                    return $"{a} / {b} = {a / b}";
            }
            else
                return "неверный знак, попробуйте снова";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}