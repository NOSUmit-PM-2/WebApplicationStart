using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double num1=0,double num2=0)
        {
            double s = num1 + num2;
            return $"{num1} + {num2} = {s}";
        }
    }
}
