using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CalculatorController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public string Index(int first, int second,string sign)
        {
            switch (sign)
            {
                case "+": return $"{first} + {second} = {first + second}";
                case "-": return $"{first} - {second} = {first - second}";
                case "*": return $"{first} * {second} = {first * second}";
                default:return "неверный знак, попробуйте снова";
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}