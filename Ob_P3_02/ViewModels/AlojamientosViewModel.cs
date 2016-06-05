using Ob_P3_02.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ob_P3_02.ViewModels
{
    public class AlojamientosViewModel
    {
        public Alojamiento UnAlojamiento { get; set; }
        public SelectList TiposAlojamientos { get; set; }
        public int IdTipoAlojamientoSelect { get; set; }
        public HttpPostedFileBase Archivo { get; set; }
        public SelectList TiposServicios { get; set; }
        public IEnumerable<String> IdServicioSelect { get; set; }
        public AlojamientosViewModel()
        {
            this.UnAlojamiento = new Alojamiento();
            CargarTiposAlojamientos();
            //CargarServicios();
        }

        private void CargarTiposAlojamientos()
        {
            BienvenidosUyContext db = new BienvenidosUyContext();
            this.TiposAlojamientos = new SelectList(db.TipoAlojamientos, "Id", "Nombre");
        }
        //private void CargarServicios()
        //{
        //    BienvenidosUyContext db = new BienvenidosUyContext();
        //    this.TiposServicios = new SelectList(db.Servicios, "Id", "Nombre");
        //}
        public bool Mapear()
        {
            if (this.Archivo != null)
            {
                if (GuardarArchivo(Archivo))
                {
                    this.UnAlojamiento.NombreArchivoPortada = Archivo.FileName;
                    BienvenidosUyContext db = new BienvenidosUyContext();

                    this.UnAlojamiento.TipoAlojamiento = db.TipoAlojamientos.Find(this.IdTipoAlojamientoSelect);
                    return true;
                }
            }
            return false;

        }
        private bool GuardarArchivo(HttpPostedFileBase archivo)
        {
            try
            {
                string ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images/fotos");
                if (!System.IO.Directory.Exists(ruta))
                    System.IO.Directory.CreateDirectory(ruta);

                ruta = System.IO.Path.Combine(ruta, archivo.FileName);
                archivo.SaveAs(ruta);
                return true;
            } catch (Exception e)
            {
                return false;
            }
            
        }
    }
}