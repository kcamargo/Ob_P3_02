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
        //[Key]
        public int Id { get; set; }

        //[Required]// este no dio problemas
        public string Nombre { get; set; }

        /*[Required]*/
        //[MaxLength(250)]
        public string Descripcion { get; set; }

        public ICollection<Alojamiento> VariosAlojamientos { get; set; }


    }
}