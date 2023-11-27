using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace database_first1.Controllers
{
    public class PersonajesController : Controller
    {
        // GET: PersonajesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PersonajesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonajesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonajesController/Create
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

        // GET: PersonajesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonajesController/Edit/5
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

        // GET: PersonajesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonajesController/Delete/5
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
