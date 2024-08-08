using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLibrary;

namespace Employers_Web_Page.Controllers
{
    public class webpageController : Controller
    {
        private readonly Iwebpage refer;

        public webpageController (Iwebpage ret)
        {
            refer = ret;
        }
        // GET: webpageController
        public ActionResult Index()
        {
            try
            {
                var data = refer.Showall();
                return View("List", data);
            }
            catch (Exception)
            {
                return View("Error");
            }
         }

        // GET: webpageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: webpageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: webpageController/Create
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

        // GET: webpageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: webpageController/Edit/5
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

        // GET: webpageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: webpageController/Delete/5
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
