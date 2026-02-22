using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Index(int a, int b)
        {
            return (a + b).ToString();
        }
    }
}
