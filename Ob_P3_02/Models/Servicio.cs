using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ob_P3_02.Models
{
    [Table("Servicio")]
    public class Servicio
    {
        [Key]
        public int Id { get; set; }

        //[Required]
        //[Column("nombre", TypeName = "varchar50", Order = 2)]
        public string Nombre { get; set; }

        //[Required]
        //[Column("descripcion", TypeName = "varchar50", Order = 3)]
        //[MaxLength(250)]
        public string Descripcion { get; set; }


    }
}