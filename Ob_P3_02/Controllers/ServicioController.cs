using Ob_P3_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ob_P3_02.Controllers
{
    public class ServicioController : Controller
    {
        public BienvenidosUyContext db = new BienvenidosUyContext();

        // GET: Servicio
        public ActionResult Index()
        {
            return View(db.Servicios.ToList());
        }

        // GET: Servicio/Details/5
        public ActionResult Details(int id)
        {
            Servicio s = db.Servicios.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }

        // GET: Servicio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Servicio/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(Servicio serv)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                db.Servicios.Add(serv);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //}
            //catch
            //{
            return View();
            //}
        }

        // GET: Servicio/Edit/5
        public ActionResult Edit(int id)
        {
            Servicio s = db.Servicios.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }

        // POST: Servicio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Servicio serv)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                db.Servicios.Add(serv);
                db.SaveChanges();

            }

            //}
            //catch
            //{
            return View();
            //}
        }

        // GET: Servicio/Delete/5
        public ActionResult Delete(int id)
        {
            Servicio s = db.Servicios.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }

        // POST: Servicio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConf(int id)
        {
            Servicio s = db.Servicios.Find(id);
            db.Servicios.Remove(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
