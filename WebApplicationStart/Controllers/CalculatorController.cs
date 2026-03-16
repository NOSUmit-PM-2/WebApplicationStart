using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a = 0, double b = 0, string c = "+")
        {
            if (c == "*")
                return $"{a} * {b} = {a * b}";
            else if (c == "-")
                return $"{a} - {b} = {a - b}";
            else if (c == "/")
                if (b != 0) return $"{a} / {b} = {a / b}";
                else return "На 0 делить нельзя";

            return $"{a} + {b} = {a + b}";
        }
    }
}
