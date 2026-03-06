using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a=0, double b=0, string op="+")
        {
            switch (op)
            { 
                case "-": return $"{a} - {b} = {a - b}";
                case "*": return $"{a} * {b} = {a * b}";
                case "+": return $"{a} + {b} = {a + b}";

                default:  return "Недопустимая операция! Скорректируйте запрос с допустимыми вариантами символов: +; -; *;";
            }
          
            
        }

    }
}
