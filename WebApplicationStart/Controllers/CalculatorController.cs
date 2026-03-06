using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a=0, double b=0, string c="+")
        {
           switch(c)
            {
                case "+": return $"{a} + {b} = {a + b}";
                case "-": return $"{a} - {b} = {a - b}";
                case "*": return $"{a} * {b} = {a * b}";
                case "/": 
                    if (b != 0) return $"{a} / {b} = {a / b}";
                    else return "На ноль делить нельзя, задайте новое значение второго параметра!";

                default: return "Недопустимая операция! Скорректируйте запрос с допустимыми вариантами символов: %2B; -; *; /;";

            }
           
        }

    }
}
