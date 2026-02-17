using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a=0, double b=0, char c = '+')
        {
            if (!"+-*".Contains(c))
                return "Неправильная операция";
            switch (c)
            {
                case '+':
                    return a + b + "";
                case '-':
                    return a - b + "";
                case '*':
                    return a * b + "";
                default:
                    return "Ошибка";
            }
        }
    }
}
