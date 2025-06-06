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
            //return "Тут решение первой задачи";
            int hour = DateTime.Now.Hour;
            string greeting;

            switch (hour)
            {
                case int n when (n >= 0 && n < 6):
                    greeting = "Доброй ночи";
                    break;
                case int n when (n >= 6 && n < 12):
                    greeting = "Доброе утро";
                    break;
                case int n when (n >= 12 && n < 18):
                    greeting = "Добрый день";
                    break;
                default:
                    greeting = "Добрый вечер";
                    break;
            }

            return greeting;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}