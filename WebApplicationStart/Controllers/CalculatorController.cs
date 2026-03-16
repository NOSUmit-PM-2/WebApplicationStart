using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ILogger<HomeController> _logger;

		public string Index(int a = 0, int b = 0)
        {
			return $"{a} + {b} = {a + b}";
		}
	}
}