using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Net.WebSockets;

namespace WebApplicationStart.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a, double b )
        {
            var sum = a + b;
            return $"{a} + {b} = {sum}";
        }
    }
}
