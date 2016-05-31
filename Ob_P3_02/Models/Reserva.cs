using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ob_P3_02.Models
{
    [Table("Reserva")]
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        //[Required]
        //[Column("fecha_init", Order = 2)]
        public DateTime FechaInicio { get; set; }

        //[Required]
        //[Column("fecha_fin", Order = 3)]
        public DateTime FechaFin { get; set; }

        //[Required]
        //[Column("cantidad_personas", TypeName = "date", Order = 4)]
        public int CantidadPersonas { get; set; }

        public Anuncio HospedajeSelect { get; set; }


        //[Required]
        //[Column("precio_total", TypeName = "int", Order = 5)]
        public double PrecioTotal { get; set; }

    }
}