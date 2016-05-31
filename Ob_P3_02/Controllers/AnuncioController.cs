using Ob_P3_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ob_P3_02.Controllers
{

    public class AnuncioController : Controller
    {
        public BienvenidosUyContext db = new BienvenidosUyContext();

        // GET: Anuncio
        public ActionResult Index()
        {
            return View(db.Anuncios.ToList());
        }

        // GET: Anuncio/Details/5
        public ActionResult Details(int id)
        {
            Anuncio an = db.Anuncios.Find(id);
            if(an == null)
            {
                return HttpNotFound();
            }
            return View(an);
        }

        // GET: Anuncio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anuncio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Anuncio an)
        {
            //try
            //{
                if (ModelState.IsValid)
                {
                    db.Anuncios.Add(an);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                
            //}
            //catch
            //{
                return View();
            //}
        }

        // GET: Anuncio/Edit/5
        public ActionResult Edit(int id)
        {
            Anuncio an = db.Anuncios.Find(id);
            if(an == null)
            {
                return HttpNotFound();
            }
            return View(an);
        }

        // POST: Anuncio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Anuncio an)
        {
            //try
            //{
                if (ModelState.IsValid)
                {
                    db.Anuncios.Add(an);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                
            //}
            //catch
            //{
                return View();
            //}
        }

        // GET: Anuncio/Delete/5
        public ActionResult Delete(int id)
        {
            Anuncio an = db.Anuncios.Find(id);
            if(an == null)
            {
                return HttpNotFound();
            }
            return View(an);
        }

        // POST: Anuncio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConf(int id)
        {
            Anuncio an = db.Anuncios.Find(id);
            db.Anuncios.Remove(an);
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
