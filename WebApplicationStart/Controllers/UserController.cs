using Microsoft.AspNetCore.Mvc;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(int id , string name, string email, string password,string login,string telephone)
        {
            var user = new User(id,name,email,password,login,telephone);
            return View(user);
        }
    }
}
