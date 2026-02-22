using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a, double b, string c)
        {
           
           if (c=="-") return $"{a} - {b} = {a - b}";
           if (c== "*") return $"{a} * {b} = {a * b}";
           if (c=="/" && b!=0) return $"{a} / {b} = {a / b}";

           if (c!=null && c != "+") return "Скорректируйте запрос";
           return $"{a} + {b} = {a + b}";
        }

    }
}
