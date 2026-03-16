using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double num1=0, double num2 = 0, string operation="+")
        {
            switch (operation)
            {
                case "+":
                    return $"{num1} + {num2} = {num1 + num2}";
                case "-":
                    return $"{num1} - {num2} = {num1 - num2}";
                case "*":
                    return $"{num1} * {num2} = {num1 * num2}";
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                    }
                    return $"{num1} / {num2} = {num1 / num2}";
                default:
                    return "Ошибка: неверный оператор!";
            }
        }
    }
}
