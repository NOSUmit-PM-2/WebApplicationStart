using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 0 && hour <= 5)
                return "Доброй ночи";

            else if (hour <= 11)
                return "Доброе утро";

            else if (hour <= 17)
                return "Добрый день";

            else
                return "Добрый вечер";
        }
    }
}
