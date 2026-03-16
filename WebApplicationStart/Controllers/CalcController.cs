using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a, double b, string c = "+")
        {
            switch (c)
            {
                case "+":
                    return $"{a} {c} {b} = {a + b}";

                case "-":
                    return $"{a} {c} {b} = {a - b}";

                case "*":
                    return $"{a} {c} {b} = {a * b}";

                case "/":
                    return (b != 0) ? $"{a} {c} {b} = {a / b}"
                        : "На ноль делить нельзя! Введите другое значение параметра b.";

                default:
                    return """
                        Недопустимая операция!
                        В параметре, в котором передается знак арифметической опреации, 
                        могут быть указаны только следующие варианты символов: %2B, - , *, /.                        
                        """;
            }
        }
    }
}
