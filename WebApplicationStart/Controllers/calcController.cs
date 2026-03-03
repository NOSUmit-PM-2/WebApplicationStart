using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class calcController : Controller
    {
        public string Index(int a = 0, int b = 0, string c = "+")
        {
            switch (c)
            {
                case "+": return $"{a} + {b} = {a + b}";
                case "-": return $"{a} - {b} = {a - b}";
                case "*": return $"{a} * {b} = {a * b}";
                case "/": if (b == 0) { return "На ноль делить нельзя"; } return $"{a} * {b} = {a * b}";
                default: return $"Введите корректную операцию(+,-,*)";
            }
        }
    }
}
