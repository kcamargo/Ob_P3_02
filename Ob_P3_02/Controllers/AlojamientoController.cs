using Ob_P3_02.Models;
using Ob_P3_02.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ob_P3_02.Controllers
{
    public class AlojamientoController : Controller
    {
        public BienvenidosUyContext db = new BienvenidosUyContext();

        // GET: Alojamiento
        public ActionResult Index()
        {
            return View(db.Alojamientos.ToList());
        }

        // GET: Alojamiento/Details/5
        public ActionResult Details(int id)
        {
            Alojamiento a = db.Alojamientos.Find(id);
            if (a == null)
            {
                return HttpNotFound();
            }
            return View(a);
        }

        // GET: Alojamiento/Create
        public ActionResult Create()
        {
            return View(new Ob_P3_02.ViewModels.AlojamientosViewModel());
        }

        // POST: Alojamiento/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(Ob_P3_02.ViewModels.AlojamientosViewModel alojamimientoVM)
        {
            try
            {
                // 
                if (alojamimientoVM.Mapear())
                {
                    Alojamiento a = alojamimientoVM.UnAlojamiento;
                    if (a != null)
                    {
                        BienvenidosUyContext db = new BienvenidosUyContext();
                        db.Entry(a.TipoAlojamiento).State = EntityState.Unchanged;
                        db.Alojamientos.Add(a);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                return View(alojamimientoVM);
            }
        }

        // GET: Alojamiento/Edit/5

        public ActionResult Edit(int id)
        {
            Alojamiento a = db.Alojamientos.Find(id);
            if (a == null)
            {
                return HttpNotFound();
            }
            AlojamientosViewModel avm = new AlojamientosViewModel();
            avm.UnAlojamiento = a;
            
            return View(avm);
           
        }

        // POST: Alojamiento/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Ob_P3_02.ViewModels.AlojamientosViewModel alojamimientoVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(alojamimientoVM.UnAlojamiento).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View();
            }
            catch (Exception ex)
            {
                return View(alojamimientoVM);
            }
        }

        // GET: Alojamiento/Delete/5
        public ActionResult Delete(int id)
        {
            Alojamiento a = db.Alojamientos.Find(id);
            if (a == null)
            {
                return HttpNotFound();
            }
            return View(a);
        }

        // POST: Alojamiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConf(int id)
        {
            Alojamiento a = db.Alojamientos.Find(id);
            db.Alojamientos.Remove(a);
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
