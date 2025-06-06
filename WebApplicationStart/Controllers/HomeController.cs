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
            var currentTime = DateTime.Now;
            var hour = currentTime.Hour;

            switch (hour)
            {
                case int h when h >= 0 && h < 6:
                    return "Доброй ночи!";
                case int h when h >= 6 && h < 12:
                    return "Доброе утро!";
                case int h when h >= 12 && h < 18:
                    return "Добрый день!";
                default:
                    return "Добрый вечер!";
            }

        }


        public string Task2(int a, int b)
        {
            int sum = a + b;
            int difference = a - b;
            return $"{a} + {b} = {sum}\n{a} - {b} = {difference}";
        }

        public string Task3(int a, int b)
        {
            int sum = a + b;
            int difference = a - b;
            int product = a * b;

            return $"{a} + {b} = {sum}\n" +
                   $"{a} - {b} = {difference}\n" +
                   $"{a} * {b} = {product}";
        }

        public string Task4(int a, int b)
        {
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            double division = b != 0 ? (double)a / b : double.NaN;

            return $"{a} + {b} = {sum}\n" +
                   $"{a} - {b} = {difference}\n" +
                   $"{a} * {b} = {product}\n" +
                   $"{a} / {b} = {(b != 0 ? division.ToString("0.##") : "∞ (деление на ноль)")}";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}