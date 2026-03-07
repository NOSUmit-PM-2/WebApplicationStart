using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }


        public string Hello()
        {
            DateTime now = DateTime.Now;

            if (now.Hour < 6)
            {
                return "Доброй ночи";
            }
            else if (now.Hour < 12)
            {
                return "Доброе утро";
            }
            else if (now.Hour < 18)
            {
                return "Добрый день";
            }
            return "Добрый вечер";
        }

        // GET: StartController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StartController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StartController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StartController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StartController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StartController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
