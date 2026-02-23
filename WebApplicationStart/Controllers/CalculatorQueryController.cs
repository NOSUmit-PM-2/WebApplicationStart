using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace WebApplicationStart.Controllers
{
    public class CalculatorQueryController : Controller
    {
        public string Index([FromQuery] double a, [FromQuery] double b , [FromQuery(Name = "c")] string operation)
        {
            var allowed = new[] { "+", "-", "*", "/" };
            if (operation.Length != 1 || System.Array.IndexOf(allowed, operation) < 0)
            {
                return "Неверный оператор в параметре \"c\". Допустимые значения: %2B (для +), -, *, /. " +
                       "Примеры корректных запросов: /calc/index?a=1&b=3&c=%2B  или  /calc/index?a=1&b=3&c=/ . " +
                       "Обратите внимание: символ '+' в значении параметра должен быть закодирован как %2B.";
            }

            double result;
            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        return $"{a} / {b} = Деление на ноль недопустимо";
                    }
                    result = a / b;
                    break;
                default:
                    operation = "+";
                    result = a + b;
                    break;
            }
            return $"{a} {operation} {b} = {result}";
        }
    }
}
