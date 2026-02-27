using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculateController : Controller
    {
        
        public string Task3(double a, double b, string c)
        {

            switch (c)
            {
                case "%2B": return $"{a} + {b} = {a + b}";
                case "*": return $"{a} * {b} = {a * b}";               
                case "-": return $"{a} - {b} = {a - b}";
                case "/":
                    if (b == 0)
                        return "На ноль делить нельзя";
                    return $"{a} / {b} = {a / b}";
                default: return $"{a} + {b} = {a + b}";
            }

        }

        
    }
}
