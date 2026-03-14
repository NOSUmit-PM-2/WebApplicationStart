using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double n1, double n2, string operation = "+")
        {
            
            switch (operation)
            {
                case "+": return $"{n1} + {n2} = {n1 + n2}";
                case "*": return $"{n1} * {n2} = {n1 * n2}";
                case "-": return $"{n1} - {n2} = {n1 - n2}";
                default: return $"Ошибка: Некорректная операция. Допустимые операции: +, -, *";
            }

        }
    }
}
