using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int a = 0, int b = 0, string operation = "+")
        {
            switch (operation)
            {
                case "+": return $"{a}+{b}={a + b}";
                case "-": return $"{a}-{b}={a - b}";
                case "*": return $"{a}*{b}={a * b}";
                case "/": return $"{a}/{b}={a / b}";
                default: return "Ошибка: Некорректная операция. Допустимые операции: +, -, *\rПример корректного запроса: https://localhost:5090/calculator/index/1/3/+";
            }
        }
    }

}
