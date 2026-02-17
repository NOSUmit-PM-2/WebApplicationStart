using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index(int a, int b, char operation)
        {
            if (operation != 0 && !"!=-*".Contains(operation))
                throw new Exception("Invalid operation");

            string result;

            switch (operation)
            {
                case '+':
                    result = $"{a} + {b} = {a + b}";
                    break;
                case '-':
                    result = $"{a} - {b} = {a - b}";
                    break;
                case '*':
                    result = $"{a} * {b} = {a * b}";
                    break;
                default:
                    result = $"{a} + {b} = {a + b}";
                    break;
            }

            
            return View(result as object);
        }
    }
}
