using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ob_P3_02.Models
{
    [Table("Anuncios")]
    public class Anuncio
    {
        [Key]
        public int Id { get; set; }

        //[Required]
        //[Column("id_alojamiento", TypeName = "int", Order = 6)]
        public int IdAlojamiento { get; set; }

        //[Required]
        //[Column("direccion", TypeName = "Varchar50", Order = 2)]
        public string Direccion { get; set; }

        //[Required]
        //[Column("nombre", TypeName = "Varchar50", Order = 3)]
        public string NombreAnuncio { get; set; }

        //[Required]
        //[Column("descripcion", TypeName = "Varchar50", Order = 4)]
        //[MaxLength(250)]
        public string DescripcionAnuncio { get; set; }

        public List<Foto> FotosAnuncio { get; set; }

        //[Required]
        //[Column("precio_base", TypeName = "Varchar50", Order = 5)]
        public int PrecioBase { get; set; }

        public List<Temporada> Feriados;

    }
}