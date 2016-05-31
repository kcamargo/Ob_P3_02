using Ob_P3_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ob_P3_02.Controllers
{
    public class FotoController : Controller
    {
        public BienvenidosUyContext db = new BienvenidosUyContext();

        // GET: Foto
        public ActionResult Index()
        {
            return View(db.Fotos.ToList());
        }

        // GET: Foto/Details/5
        public ActionResult Details(int id)
        {
            Foto f = db.Fotos.Find(id);
            if (f == null)
            {
                return HttpNotFound();
            }
            return View(f);
        }

        // GET: Foto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Foto/Create
        [HttpPost]
        public ActionResult Create(Foto fot)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                db.Fotos.Add(fot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            //}
            //catch
            //{
            return View();
            //}
        }

        // GET: Foto/Edit/5
        public ActionResult Edit(int id)
        {
            Foto f = db.Fotos.Find(id);
            if (f == null)
            {
                return HttpNotFound();

            }
            return View(f);
        }

        // POST: Foto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Foto fto)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                db.Fotos.Add(fto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            //}
            //catch
            //{
            return View();
            //}
        }

        // GET: Foto/Delete/5
        public ActionResult Delete(int id)
        {
            Foto f = db.Fotos.Find(id);
            if (f == null)
            {
                return HttpNotFound();
            }
            return View(f);
        }

        // POST: Foto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConf(int id)
        {
            Foto f = db.Fotos.Find(id);
            db.Fotos.Remove(f);
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
