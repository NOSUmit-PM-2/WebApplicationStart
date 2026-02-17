using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index(int a, int b)
        {
            string result = $"{a} + {b} = {a + b}";
            return View(result as object);
        }
    }
}
