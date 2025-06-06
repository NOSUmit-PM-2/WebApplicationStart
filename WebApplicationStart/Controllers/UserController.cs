using Microsoft.AspNetCore.Mvc;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel testUser = new UserViewModel("Test", "keks@mail.com", "password", "+77777777");
            return View(testUser);
        }
    }
}
