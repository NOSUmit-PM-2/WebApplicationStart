using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int a = 0, int b = 0)
        {
            return $"{a} + {b} = {a+b}";
        }
    }

}
