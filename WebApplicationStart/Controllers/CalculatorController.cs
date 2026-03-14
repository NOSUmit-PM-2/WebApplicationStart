using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int n1 = 0, int n2 = 0)
        {
            return $"{n1}+{n2}={n1 + n2}";
        }
    }
}
