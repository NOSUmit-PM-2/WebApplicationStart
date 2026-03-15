using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class Calculator : Controller
    {
        public string Index(double a, double b)
        {
            var sum = a + b;
            return $"{a} + {b} = {sum}";
        }
    }
}
