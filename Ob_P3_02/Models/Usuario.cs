using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ob_P3_02.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public enum Roles { Anfitrion, Husped, Chusma }

        //[Required]
        //[Column("rol", TypeName = "varchar50", Order = 2)]
        public Roles Rol { get; set; }

        //[Required(ErrorMessage = "El nombre no se puede dejar vacío")]
        //[Column("nombre", TypeName = "varchar50", Order = 3)]
        //[DisplayName("Nombre de usuario")]
        public string NombreUsuario { get; set; }
        //[Required]
        //[EmailAddress]
        //[Column("email", Order = 5)]
        public string Email { get; set; }

        //[Required]
        //[Column("apellido", TypeName = "varchar50", Order = 4)]
        public string ApellidoUsuario { get; set; }

        //[Required(ErrorMessage = "La contraseña no se puede dejar vacía")]
        //[DataType(DataType.Password)]
        //[MinLength(8, ErrorMessage = "Largo mínimo de la contraseña: 8"),
        //        MaxLength(12, ErrorMessage = "Largo máximo de la contraseña:12")]

        public string Contrasena { get; set; }

        //[Required]
        //[Column("direccion", TypeName = "varchar50", Order = 6)]
        public string Direccion { get; set; }

        //[Required]
        //[Column("telefono", TypeName = "varchar50", Order = 7)]
        public string Telefono { get; set; }

        //[Required]
        //[Column("foto", TypeName = "varchar50", Order = 8)]
        public string Foto { get; set; }

        //[Required]
        //[Column("descripcion", TypeName = "varchar50", Order = 3)]
        //[MaxLength(250)]
        public string Descripcion { get; set; }

    }

}