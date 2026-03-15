using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a = 0, double b = 0)
        {
            var sum = a + b;
            return $"{a} + {b} = {sum}";
        }
    }
}
