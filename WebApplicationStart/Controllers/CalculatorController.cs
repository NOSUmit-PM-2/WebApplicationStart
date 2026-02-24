using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b, string op)
        {
            switch (op)
            { 
                case "-": return $"{a} - {b} = {a - b}";
                case "*": return $"{a} * {b} = {a * b}";
            }
            if (op!=null && op!="+") return "Скорректируйте запрос";
            return $"{a} + {b} = {a + b}";
        }

    }
}
