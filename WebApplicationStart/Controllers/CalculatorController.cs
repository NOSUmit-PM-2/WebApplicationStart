using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a = 0, double b = 0, char c = '+')
        {
            return c switch
            {
                '+' => (a + b).ToString(),
                '*' => (a * b).ToString(),
                '-' => (a - b).ToString(),
                '/' => b == 0 ? "На ноль делить нельзя" : (a / b).ToString(),
                _ => "Ошибочная операция"
            };
        }
    }
}
