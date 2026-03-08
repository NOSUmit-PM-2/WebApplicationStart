using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double? a, double? b)
        {
            double a1 = a ?? 0;
            double b1 = b ?? 0;
            double result = a1 + b1;
            return $"{a1} + {b1} = {result}";
        }
    }
}
