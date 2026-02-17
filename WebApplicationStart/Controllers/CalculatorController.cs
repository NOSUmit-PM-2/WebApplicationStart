using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index(double a, double b, string operation)
        {
            string result;

            switch (operation)
            {
                case "%2B":
                    result = $"{a} + {b} = {a + b}";
                    break;
                case "-":
                    result = $"{a} - {b} = {a - b}";
                    break;
                case "*":
                    result = $"{a} * {b} = {a * b}";
                    break;
                case "/":
                    if (b == 0)
                        throw new Exception("Zero divide exception");
                    result = $"{a} / {b} = {a / b}";
                    break;
                default:
                    result = $"{a} + {b} = {a + b}";
                    break;
            }

            
            return View(result as object);
        }
    }
}
