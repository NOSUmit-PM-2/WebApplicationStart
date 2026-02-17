using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public string Hello()
        {
            int time= DateTime.Now.Hour;
            if (time < 6) return "доброй ночи";
            if (time < 12) return "доброе утро";
            if (time < 18) return "добрый день";
            return "добрый вечер";

        }

    }
}