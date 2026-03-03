using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class calculatorController : Controller
    {
        public string Index(int num1 = 0, int num2 = 0)
        {
            return $"{num1} + {num2} = {num1 + num2}" ;
        }
    }
}
