using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            int currentHour = DateTime.Now.Hour;

            if (currentHour < 6)
                return "Доброй ночи";
            if (currentHour < 12)
                return "Доброе утро";

            if (currentHour < 18)
                return "Добрый день";

            return "Добрый вечер";
        }
    }
}
