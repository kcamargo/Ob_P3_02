using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ob_P3_02.Models
{
    [Table("Tipo_Alojamiento")]
    public class TipoAlojamiento
    {
        //[Key]
        public int Id { get; set; }

        //[Required]
        //[Column("nombre", Order = 2)]
        public string Nombre { get; set; }

        //[Required]
        //[Column("descripcion", Order = 3)]
        //[MaxLength(250)]
        public string Descripcion { get; set; }
    }
}