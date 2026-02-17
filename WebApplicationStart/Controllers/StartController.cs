using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            int hours = DateTime.Now.Hour;
            if (hours < 6)
                return "Доброй ночи";
            if (hours < 12)
                return "Доброе утро";
            if (hours < 18)
                return "Добрый день";
            else
                return "Добрый вечер";
        }
    }
    
    }
