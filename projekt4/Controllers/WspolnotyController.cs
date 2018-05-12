using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekt4.Controllers
{
    public class WspolnotyController : Controller
    {
        // GET: Wspolnoty
        public ActionResult Index()
        {
            return View();
        }

        // GET: Wspolnoty/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Wspolnoty/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wspolnoty/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Wspolnoty/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Wspolnoty/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Wspolnoty/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Wspolnoty/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
