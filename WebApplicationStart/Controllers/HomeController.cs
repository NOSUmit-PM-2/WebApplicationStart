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

       

        

        
        

        public string Task2(double a, double b)
        {
            return $"{a + b}";
        }
        public string Task3(double a, double b, string c="+")
        {
            return c switch
            {
                "+" => (a + b).ToString(),
                "*" => (a * b).ToString(),
                "-" => (a - b).ToString(),
                _ => "Ошибочная операция"
            } ;
        }
        public string Task4(double a, double b, string c="+")
        {
            return c switch
            {
                "+" => (a + b).ToString(),
                "*" => (a * b).ToString(),
                "-" => (a - b).ToString(),
                "/" => b==0? "На ноль делить нельзя":(a/b).ToString(),
                _ => "Ошибочная операция"
            } ;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}