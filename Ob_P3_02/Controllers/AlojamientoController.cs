using Ob_P3_02.Models;
using System;
using System.Collections.Generic;
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
            return View(new ViewModels.AlojamientosViewModel());
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
            return View(new ViewModels.AlojamientosViewModel());
        }

        // POST: Alojamiento/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(ViewModels.AlojamientosViewModel alojamimientoVM)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                Alojamiento a = new Alojamiento()
                {
                    Nombre = alojamimientoVM.Nombre,
                    TipoHabitacion = alojamimientoVM.TipoHabitacion,
                    TipoBanio = alojamimientoVM.TipoBanio,
                    CapacidadXPersona = alojamimientoVM.CapacidadXPersona,
                    Ciudad = alojamimientoVM.Ciudad,
                    Barrio = alojamimientoVM.Barrio,
                    //TipoAlojamiento = new TipoAlojamiento { Nombre = alojamimientoVM.NombreTipoAloj },
                    //TipoDeServicios = new Servicio { Nombre = alojamimientoVM.NombreTipoServicio }
                };
                db.Alojamientos.Add(a);
                db.SaveChanges();
                return View("Details", a);
            }
         
            //}
            //catch
            //{
            return View(alojamimientoVM);
            //}
        }

        // GET: Alojamiento/Edit/5
        public ActionResult Edit(int id)
        {
            Alojamiento a = db.Alojamientos.Find(id);
            if (a == null)
            {
                return HttpNotFound();
            }
            return View(a);
        }

        // POST: Alojamiento/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Alojamiento aloj)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                db.Alojamientos.Add(aloj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            //}
            //catch
            //{
            return View();
            //}
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
