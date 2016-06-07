using Ob_P3_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ob_P3_02.ViewModels
{
    public class AnunciosViewModel
    {
        public Anuncio Anuncio { get; set; }

        public SelectList Alojamientos { get; set; }

        public int IdAlojamiento { get; set; }

        public HttpPostedFileBase Archivo { get; set; }

        public AnunciosViewModel()
        {
            this.Anuncio = new Anuncio();
            CargarAlojamientos();

        }

        private void CargarAlojamientos()
        {
            BienvenidosUyContext db = new BienvenidosUyContext();
            this.Alojamientos = new SelectList(db.Alojamientos, "Id", "Nombre");
        }
        public bool Mapear()
        {
            if (this.Archivo != null)
            {
                if (GuardarArchivo(Archivo))
                {
                    this.Anuncio.NombreArchivoPortada = Archivo.FileName;
                    BienvenidosUyContext db = new BienvenidosUyContext();

                    this.Anuncio.Alojamimento = db.Alojamientos.Find(this.IdAlojamiento);
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
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}