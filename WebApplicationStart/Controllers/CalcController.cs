using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalcController : Controller
    {
        // GET: HomeCalculator
        public string Index(double a = 0, double b = 0, string c = "+")
        {
            if (c == "-")
            {
                return (a - b).ToString();
            }
            else if (c == "+")
            {
                return (a + b).ToString();
            }
            else if (c == "/")
            {
                if (b == 0)
                {
                    return "На ноль делить нельзя!";
                    
                }
                return (a / (double)b).ToString();
            }
            else if (c == "*")
            {
                return (a * b).ToString();
            }

            return "Скорректируйте запрос!";

        }

        // GET: HomeCalculator/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeCalculator/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeCalculator/Create
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

        // GET: HomeCalculator/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeCalculator/Edit/5
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

        // GET: HomeCalculator/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeCalculator/Delete/5
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
