using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class startController : Controller
    {
        public string Hello()
        {
            var time = DateTime.Now;
            if (time.Hour < 6)
            {
                return "Доброй ночи";
            }
            if (time.Hour < 12)
            {
                return "Доброе утро";
            }
            if (time.Hour < 18)
            {
                return "Добрый день";
            }
            return "Добрый вечер";
        }
    }
}
