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
            DateTime time = DateTime.Now;
            string result = "";

            if (time.Hour < 6)
                return "Доброй ночи";
            if (time.Hour < 12)
                return "Доброе утро";
            if (time.Hour < 18)
                return "Добрый день";

            return "Добрый вечер";
        }

        public string Task2(int a, int b)
        {
            return a + " + " + b + " = " + (a + b);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}