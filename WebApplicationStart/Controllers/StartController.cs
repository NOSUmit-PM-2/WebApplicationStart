using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Hello");
        }

        public IActionResult Hello()
        {
            string result = "Добрый вечер";

            int[] times = DateTime.Now.ToShortTimeString().Split(":").Select(x => Convert.ToInt32(x)).ToArray();

            TimeOnly current = new(times[0], times[1]);

            if (new TimeOnly(5, 59) >= current)
                result = "Доброй ночи";
            else if (new TimeOnly(11, 59) >= current)
                result = "Доброе утро";
            else if (new TimeOnly(17, 59) >= current)
                result = "Добрый день";

            return View("Index", result as object);
        }
    }
}
