using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Hello()
        {
            DateTime now = DateTime.Now;
            string greeting;

            if (now.Hour >= 0 && now.Hour < 6)
            {
                greeting = "Доброй ночи";
            }
            else if (now.Hour >= 6 && now.Hour < 12)
            {
                greeting = "Доброе утро";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                greeting = "Добрый день";
            }
            else
            {
                greeting = "Добрый вечер";
            }

            return Content(greeting);
        }
    }
}
