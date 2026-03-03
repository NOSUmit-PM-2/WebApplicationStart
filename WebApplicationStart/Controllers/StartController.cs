using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            var hour = DateTime.Now.Hour;
            if (hour < 6)
            {
                return "Доброй ночи!";
            }
            if (hour < 12)
            {
                return "Доброе утро!";
            }
            if (hour < 18)
            {
                return "Добрый день!";
            }
            return "Добрый вечер!";

        }
    }
}
