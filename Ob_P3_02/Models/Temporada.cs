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
        public DateTime FechaInicio { get; set; }

        //[Required]
        public DateTime FechaFin { get; set; }

        //[Required]
        public int Importe { get; set; }

        //[Required]
        public int Id_anuncio { get; set; }
    }
}