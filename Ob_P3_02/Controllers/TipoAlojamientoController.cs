using Ob_P3_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ob_P3_02.Controllers
{
    public class TipoAlojamientoController : Controller
    {
        public BienvenidosUyContext db = new BienvenidosUyContext();

        // GET: TipoAlojamiento
        public ActionResult Index()
        {
            return View(db.TipoAlojamientos.ToList());
        }

        // GET: TipoAlojamiento/Details/5
        public ActionResult Details(int id)
        {
            TipoAlojamiento ta = db.TipoAlojamientos.Find(id);
            if (ta == null)
            {
                return HttpNotFound();

            }
            return View(ta);
        }

        // GET: TipoAlojamiento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoAlojamiento/Create
        [HttpPost]
        public ActionResult Create(TipoAlojamiento tal)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                db.TipoAlojamientos.Add(tal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            //}
            //catch
            //{
            return View();
            //}
        }

        // GET: TipoAlojamiento/Edit/5
        public ActionResult Edit(int id)
        {
            TipoAlojamiento ta = db.TipoAlojamientos.Find(id);
            if (ta == null)
            {
                return HttpNotFound();

            }
            return View(ta);
        }

        // POST: TipoAlojamiento/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoAlojamiento tal)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                db.TipoAlojamientos.Add(tal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            //}
            //catch
            //{
            return View();
            //}
        }

        // GET: TipoAlojamiento/Delete/5
        public ActionResult Delete(int id)
        {
            TipoAlojamiento ta = db.TipoAlojamientos.Find(id);
            if (ta == null)
            {
                return HttpNotFound();

            }
            return View(ta);
        }

        // POST: TipoAlojamiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConf(int id)
        {
            TipoAlojamiento ta = db.TipoAlojamientos.Find(id);
            db.TipoAlojamientos.Remove(ta);
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
