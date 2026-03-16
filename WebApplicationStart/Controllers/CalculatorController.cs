using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index(double a, double b, string c = "+")
        {
            double result = 0;
            switch (c)
            {
                case "+": result = a + b; break;
                case "-": result = a - b; break;
                case "*": result = a * b; break;
                case "/":
                    {
                        if (b == 0) return Content("b не может быть равен нулю");
                        result = a / b;
                        break;
                    }
                default:
                    return Content("Неправильно указана операция");
            }
            return Content($"{a} {c} {b} = {result}");   
        }
    }
}
