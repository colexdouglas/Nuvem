using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Nuvem.Services
{
    public class PharmacyService : Controller
    {
        // GET: PharmacyService
        public ActionResult Index()
        {
            return View();
        }

        // GET: PharmacyService/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PharmacyService/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PharmacyService/Create
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

        // GET: PharmacyService/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PharmacyService/Edit/5
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

        // GET: PharmacyService/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PharmacyService/Delete/5
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
