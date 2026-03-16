using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index(double a, double b)
        {
            return Content($"{a} + {b} = {a + b}");
        }
    }
}
