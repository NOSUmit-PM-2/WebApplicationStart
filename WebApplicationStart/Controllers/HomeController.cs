using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
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
            if (hour >= 18)
            {
                return "Вечер";
            }
            if (hour >= 12)
            {
                return "День";
            }
            if (hour >= 6)
            {
                return "Утро";
            }
            return "Ночь";
        }
        public string Task2(double id, double dopId)
        {
            return $"{id} + {dopId} = {id + dopId}";
        }
        public string Task3(double id, double dopId, string esheDopId = "+")
        {
            switch (esheDopId)
            {
                case "+": return $"{id} + {dopId} = {id + dopId}";
                case "-": return $"{id} - {dopId} = {id - dopId}";
                case "*": return $"{id} * {dopId} = {id * dopId}";
                default: return $"В качестве пятого сегмента необходимо передать одну из желаемых операций (+, -, *)";
            }
        }
        public string Task4(double a, double b, string c = "+")
        {
            switch (c)
            {
                case null:
                case "+": return $"{a} + {b} = {a + b}";
                case "-": return $"{a} - {b} = {a - b}";
                case "*": return $"{a} * {b} = {a * b}";
                case "/": if (b != 0) return $"{a} / {b} = {a / b}"; else return "Делить на 0 нельзя ";
                default: return $"В качестве третьего параметра запроса необходимо передать одну из желаемых операций (+, -, *, /)";
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}