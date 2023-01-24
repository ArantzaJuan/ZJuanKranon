using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SLApi.Controllers
{
    public class ApiLibroController : Controller
    {
        // GET: ApiLibroController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApiLibroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApiLibroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApiLibroController/Create
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

        // GET: ApiLibroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApiLibroController/Edit/5
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

        // GET: ApiLibroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApiLibroController/Delete/5
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
