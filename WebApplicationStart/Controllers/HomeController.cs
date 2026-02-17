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
            var time = DateTime.Now;
            if (time.Hour < 6)
            {
                return "Доброй ночи";
            }
            if (time.Hour < 12) { 
                return "Доброе утро";
            }
            if (time.Hour< 18){
                return "Добрый день";
            }
            return "Добрый вечер";


        }
        public string Task2(int num1 = 0, int num2 = 0)
        {
            return $"{num1} + {num2} = {num1 + num2}" ;


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}