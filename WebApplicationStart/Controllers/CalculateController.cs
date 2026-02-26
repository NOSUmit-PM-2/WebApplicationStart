using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculateController : Controller
    {
        
        public string Task3(double n1, double n2, string operation = "+")
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
