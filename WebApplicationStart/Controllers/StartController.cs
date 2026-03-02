using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            int timeHour = DateTime.Now.Hour;
            string hello = "";

            switch(timeHour)
            {
                case int n when (n >= 0 && n < 6):
                    hello = "Доброе утро";
                    break;
                case int n when (n >= 6 && n < 12):
                    hello = "Добрый день";
                    break;
                case int n when (n >= 12 && n < 18):
                    hello = "Добрый вечер";
                    break;
                case int n when (n >= 18 && n < 24):
                    hello = "Доброй ночи";
                    break;
            }
            return hello;
        }
    }
}
