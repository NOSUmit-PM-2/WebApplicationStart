using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        private readonly ILogger<HomeController> _logger;

		public string Hello()
        {
            int hour = DateTime.Now.Hour;
            if (hour < 6)
            {
                return "Доброй ночи";
            }

			if (hour < 12)
			{
				return "Доброе утро";
			}
			if (hour < 18)
			{
				return "Добрый день";
			}
			else
			{
				return "Добрый вечер";
			}

        }
    }
}