using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        private readonly ILogger<HomeController> _logger;

		public string Task2(int a, int b)
        {
			return $"{a} + {b} = {a + b}";
		}
	}
}