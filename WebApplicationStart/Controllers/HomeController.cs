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

            //ffgfhhghdghf
            return View();
        }


        public IActionResult Tasks()
        {
            return View();
        }

        public string Task1()
        {

            var time = DateTime.Now.Hour;
            if (time >= 0 && time < 6)
                return "Доброй ночи";
            if (time >= 6 && time < 12)
                return "Доброе утро";
            if (time >= 12 && time < 18)
                return "Добрый день";
            return "Добрый вечер";
        
        }

        public string Task2(int a, int b)
        {

            return $"{a}+{b}={a + b}";

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}