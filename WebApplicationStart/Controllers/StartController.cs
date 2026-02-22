using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Hello()
        {
            int hour = DateTime.Now.Hour;
            string temp;

            if (hour >= 0 && hour < 6)
            {
                temp = "Доброй ночи";
            }
            else if (hour >= 6 && hour < 12)
            {
                temp = "Доброе утро";
            }
            else if (hour >= 12 && hour < 18)
            {
                temp = "Добрый день";
            }
            else
            {
                temp = "Добрый вечер";
            }
            ViewBag.Greeting = temp;
            return View();
        }
    }
}
