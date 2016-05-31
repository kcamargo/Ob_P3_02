using Ob_P3_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ob_P3_02.Controllers
{
    public class TemporadaController : Controller
    {
        public BienvenidosUyContext db = new BienvenidosUyContext();

        // GET: Temporada
        public ActionResult Index()
        {
            return View(db.Temporadas.ToList());
        }

        // GET: Temporada/Details/5
        public ActionResult Details(int id)
        {
            Temporada t = db.Temporadas.Find(id);
            if (t == null)
            {
                return HttpNotFound();
            }
            return View(t);
        }

        // GET: Temporada/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Temporada/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Temporada temp)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                db.Temporadas.Add(temp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            //}
            //    catch
            //    {
            return View();
            //}
        }

        // GET: Temporada/Edit/5
        public ActionResult Edit(int id)
        {
            Temporada t = db.Temporadas.Find(id);
            if (t == null)
            {
                return HttpNotFound();
            }
            return View(t);
        }

        // POST: Temporada/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Temporada temp)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                db.Temporadas.Add(temp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            //}
            //    catch
            //    {
            return View();
            //}
        }

        // GET: Temporada/Delete/5
        public ActionResult Delete(int id)
        {
            Temporada t = db.Temporadas.Find(id);
            if (t == null)
            {
                return HttpNotFound();
            }
            return View(t);
        }

        // POST: Temporada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConf(int id)
        {

            Temporada t = db.Temporadas.Find(id);
            db.Temporadas.Remove(t);
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
