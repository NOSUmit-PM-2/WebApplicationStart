using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class calculatorController : Controller
    {
        public string Index(int num1 = 0, int num2 = 0, string op = "+")
        {
            switch (op)
            {
                case "+": return $"{num1} + {num2} = {num1 + num2}";
                case "-": return $"{num1} - {num2} = {num1 - num2}";
                case "*": return $"{num1} * {num2} = {num1 * num2}";
                default: return $"Введите корректную операцию(+,-,*)";
            }
        }
    }
}
