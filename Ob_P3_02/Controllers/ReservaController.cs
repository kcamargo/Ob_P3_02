using Ob_P3_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ob_P3_02.Controllers
{
    public class ReservaController : Controller
    {
        public BienvenidosUyContext db = new BienvenidosUyContext();

        // GET: Reserva
        public ActionResult Index()
        {
            return View(db.Reservas.ToList());
        }

        // GET: Reserva/Details/5
        public ActionResult Details(int id)
        {
            Reserva r = db.Reservas.Find(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        // GET: Reserva/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reserva/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reserva res)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                db.Reservas.Add(res);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            //}
            //catch
            //{
            return View();
            //}
        }

        // GET: Reserva/Edit/5
        public ActionResult Edit(int id)
        {
            Reserva r = db.Reservas.Find(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        // POST: Reserva/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Reserva rsva)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                db.Reservas.Add(rsva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            //}
            //catch
            //{
            return View();
            //}
        }

        // GET: Reserva/Delete/5
        public ActionResult Delete(int id)
        {
            Reserva r = db.Reservas.Find(id);
            if (r == null)
            {
                return HttpNotFound();
            }
            return View(r);
        }

        // POST: Reserva/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConf(int id)
        {
            Reserva r = db.Reservas.Find(id);
            db.Reservas.Remove(r);
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
