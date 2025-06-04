using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public string Hellow()
        {
            var Hour = DateTime.Now.Hour;

            if (Hour >= 0 && Hour < 6) return "Ночь";
            if (Hour >= 6 && Hour < 12) return "Утро";
            if (Hour >= 12 && Hour < 18) return "День";

            return "Вечер";
        }
    }
}
