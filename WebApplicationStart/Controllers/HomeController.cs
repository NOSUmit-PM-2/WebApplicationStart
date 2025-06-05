using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tasks()
        {
            return View();
        }

        public string Task1()
        {
            var timeInHour = DateTime.Now.Hour;
            if (timeInHour < 6)
                return "Доброй ночи";
            if (timeInHour < 12)
                return "Доброе утро";
            if (timeInHour < 18)
                return "Добрый день";
            return "Добрый вечер";
        }
        public string Task2(double a, double b)
        {
            return $"{a} + {b} = {a + b}";
        }

        public string Task3(double a = 0, double b = 0, char op = '+')
        {
            switch (op)
            {
                case '+': return $"{a} + {b} = {a + b}";
                case '-': return $"{a} - {b} = {a - b}";
                case '*': return $"{a} * {b} = {a * b}";
                default:
                    return "Данная операция недоступна.\nСущетсвует возможность только ввода '+', '-' и '*'";
            }
        }

        public string Task4(double a, double b, char op = '+')
        {
            switch (op)
            {
                case '+': return $"{a} + {b} = {a + b}";
                case '-': return $"{a} - {b} = {a - b}";
                case '*': return $"{a} * {b} = {a * b}";
                case '/': return b != 0 ? $"{a} / {b} = {a / b}" : "Делить на 0 нельзя!";
                default:
                    return "Данная операция недоступна.\nСущетсвует возможность только ввода '+', '-' и '*', '/'";
            }
        }
    }
}