using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double num1=0,double num2=0, string sign="+")
        {
            double res = 0;
            switch (sign)
            {
                case "+":
                    res = num1+num2;
                    break;
                case "-":
                    res = num1 - num2;
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                default:
                    return "ошибка ввода недопустимая операция";
            }

            return $"{num1} {sign} {num2} = {res}";
        }
    }
}
