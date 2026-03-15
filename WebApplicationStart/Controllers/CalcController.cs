using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a = 0, double b = 0, string c = "+")
        {
            double result;

            switch (c)
            {
                case "+":
                    result = a + b;
                    return $"{a} + {b} = {result}";

                case "-":
                    result = a - b;
                    return $"{a} - {b} = {result}";

                case "*":
                    result = a * b;
                    return $"{a} * {b} = {result}";

                case "/":
                    if (b == 0)
                    {
                        return "На ноль делить нельзя!!!";
                    }
                    result = a / b;
                    return $"{a} / {b} = {result}";

                default:
                    return $"Знак '{c}' не поддерживается. Используйте +, -, *, /";
            }
        }
    }
}
