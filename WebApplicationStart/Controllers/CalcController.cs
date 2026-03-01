using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a=0, double b = 0, string c="+")
        {
            switch (c)
            {
                case "+":
                    return $"{a} + {b} = {a + b}";
                case "-":
                    return $"{a} - {b} = {a - b}";
                case "*":
                    return $"{a} * {b} = {a * b}";
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                    }
                    return $"{a} / {b} = {a / b}";
                default:
                    return "Ошибка: неверный оператор!";
            }
        }
    }

}