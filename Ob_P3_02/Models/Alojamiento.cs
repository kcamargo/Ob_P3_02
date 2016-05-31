using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ob_P3_02.Models
{
    [Table("Alojamiento")]
    public class Alojamiento
    {
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "No te olvides del apellido")]
        //[Column("nombre", TypeName = "Varchar50", Order = 2)]
        public string Nombre { get; set; }

        //[Required]
        //[Column("tipo_habitacion", TypeName = "Varchar50", Order = 3)]
        public string TipoHabitacion { get; set; }//true privada

        //[Required]
        //[Column("tipo_banio", TypeName = "Varchar50", Order = 4)]
        public string TipoBanio { get; set; }//true privado

        //[Required]
        //[Column("capacidad_persona", TypeName = "int", Order = 5)]
        public int CapacidadXPersona { get; set; }

        //[Required]
        //[Column("ciudad", TypeName = "Varchar50", Order = 6)]
        public string Ciudad { get; set; }

        //[Required]
        //[Column("barrio", TypeName = "Varchar50", Order = 7)]
        public string Barrio { get; set; }

        public TipoAlojamiento TipoAlojamiento { get; set; }

        public Servicio TipoDeServicios { get; set; }

    }
}