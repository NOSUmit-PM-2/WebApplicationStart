using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Hello()
        {
            var time = DateTime.Now.Hour;
            if (time < 6)
                return "Доброй ночи";
            if (time < 12)
                return "Доброе утро";
            if (time < 18)
                return "Добрый день";
            return "Добрый вечер";
        }
    }
}
