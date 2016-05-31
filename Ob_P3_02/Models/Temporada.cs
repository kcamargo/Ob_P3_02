using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ob_P3_02.Models
{
    [Table("Temporada")]
    public class Temporada
    {
        [Key]
        public int Id { get; set; }

        //[Required]
        //[Column("fecha_inicio", TypeName = "date", Order = 2)]
        public DateTime FechaInicio { get; set; }

        //[Required]
        //[Column("fecha_fin", TypeName = "date", Order = 3)]
        public DateTime FechaFin { get; set; }

        //[Required]
        //[Column("importe", TypeName = "int", Order = 4)]
        public int Importe { get; set; }

        //[Required]
        //[Column("id_anuncio", TypeName = "int", Order = 5)]
        public int Id_anuncio { get; set; }
    }
}