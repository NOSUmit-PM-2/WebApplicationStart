using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(double a=0, double b=0)
        {
            return $"{a} + {b} = {a+b}";
        }

    }
}
