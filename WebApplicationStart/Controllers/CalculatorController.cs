using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double num1 = 0, double num2 = 0, string op = "+")
        {
            double res = 0;
            if (op == "+")
            {
                res = num1 + num2;
            }
            else if (op == "-")
            {
                res = num1 - num2;
            }
            else if (op == "*")
            {
                res = num1 * num2;
            }
            else
            {
                return "Операция не поддерживается";
            }
            return $"{num1} {op} {num2} = {res}";
        }
    }
}
