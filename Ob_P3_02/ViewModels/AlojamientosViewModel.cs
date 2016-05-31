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
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoHabitacion { get; set; }
        public string TipoBanio { get; set; }
        public int CapacidadXPersona { get; set; }
        public string Ciudad { get; set; }
        public string Barrio { get; set; }
        public IList<SelectListItem> TiposAlojamientos { get; set; }
        public string NombreTipoAloj { get; set; }
        public IList<SelectListItem> TiposServicios { get; set; }
        public string NombreTipoServicio { get; set; }
        public AlojamientosViewModel()
        {
            BienvenidosUyContext db = new BienvenidosUyContext();
            //this.TiposAlojamientos = (from t in db.TipoAlojamientos
            //              select new SelectListItem
            //              {
            //                  Selected = false,
            //                  Text = t.Nombre,
            //                  Value = SqlFunctions.StringConvert((double?)t.Id)
            //              }).ToList();

            //this.TiposServicios = (from d in db.Servicios
            //                       select new SelectListItem
            //                          {
            //                              Selected = false,
            //                              Text = d.Nombre,
            //                              Value = SqlFunctions.StringConvert((double?)d.Id)
            //                          }).ToList();
        }
    }
}