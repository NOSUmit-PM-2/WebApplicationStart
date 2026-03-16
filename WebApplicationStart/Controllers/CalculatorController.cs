using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index(double a, double b, string operation)
        {
            double c = 0;
            switch (operation)
            {
                case "+": c = a + b; break;
                case "-": c = a - b; break;
                case "*": c = a * b; break;
                case null: c = a + b; operation = "+"; break;
                default:
                    return Content("Неправильно указана операция");
            }
            return Content($"{a} {operation} {b} = {c}");
        }
    }
}
