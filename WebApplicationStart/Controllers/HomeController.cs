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
            //мем смешной но результат важнее
            return View();
        }


        public IActionResult Tasks()
        {
            return View();
        }

        public string Task1()
        {
            string result = "Решение первой задачи";
            DateTime dateTime = DateTime.Now;
            if (0 < dateTime.Hour && dateTime.Hour < 6)
                result += $"\nНочь";
            else if (6 < dateTime.Hour && dateTime.Hour < 12)
                result += "\nУтро";
            else if (12 < dateTime.Hour && dateTime.Hour < 24)
                result += "\nВечер";
            return result;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}