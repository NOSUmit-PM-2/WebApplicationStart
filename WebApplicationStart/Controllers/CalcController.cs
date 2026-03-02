using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class CalcController : Controller
    {
        private readonly ILogger<HomeController> _logger;

		public string Index(int a = 0, int b = 0, string c = "+")
		{
			switch (c)
			{
				case "+": return $"{a} + {b} = {a + b}";
				case "-": return $"{a} - {b} = {a - b}";
				case "*": return $"{a} * {b} = {a * b}";
				case "/": if (b != 0) return $"{a} / {b} = {(double)a / b}"; else return "На 0 делить нельзя";
			}
			return "введите корректные данные";
		}
	}
}