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
            int hour = DateTime.Now.Hour;
            if (hour >= 18)
            {
                return "Вечер";
            }
            else if (hour >= 12)
            {
                return "День";
            }
            else if (hour >= 6)
            {
                return "Утро";
            }
            else
            {
                return "Ночь";
            }
        }
        public string Task2(double id, double dopId)
        {
            return $"{id} + {dopId} = {id + dopId}";
        }
        public string Task3(double id, double dopId, string esheDopId = "+")
        {
            if (esheDopId == "+")
            {
                return $"{id} + {dopId} = {id + dopId}";
            }
            else if (esheDopId == "-")
            {
                return $"{id} - {dopId} = {id - dopId}";
            }
            else if (esheDopId == "*")
            {
                return $"{id} * {dopId} = {id * dopId}";
            }
            else
            {
                return $"В качестве пятого сегмента необходимо передать одну из желаемых операций (+, -, *)";
            }
        }
        public string Task4(double a, double b, string c = "+")
        {
            if (c == "+")
            {
                return $"{a} + {b} = {a + b}";
            }
            else if (c == "-")
            {
                return $"{a} - {b} = {a - b}";
            }
            else if (c == "*")
            {
                return $"{a} * {b} = {a * b}";
            }
            else if (c == "/")
            {
                if (b > 0)
                {
                    return $"{a} / {b} = {a / b}";
                }
                return "Делить на 0 нельзя";
            }
            else
            {
                return $"В качестве третьего параметра запроса необходимо передать одну из желаемых операций (+, -, *, /)";
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}