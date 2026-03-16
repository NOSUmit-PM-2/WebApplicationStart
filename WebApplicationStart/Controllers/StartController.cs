using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public StartController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public string Hello()
        {
            if (DateTime.Now.Hour < 6)
                return "Доброй ночи";
            else if (DateTime.Now.Hour < 12)
                return "Доброе утро";
            else if (DateTime.Now.Hour < 18)
                return "Добрый день";
            else
                return "Добрый вечер";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}