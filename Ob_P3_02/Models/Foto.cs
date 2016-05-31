using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ob_P3_02.Models
{
    [Table("Foto")]
    public class Foto
    {
        [Key]
        public int Id { get; set; }

        //[Required]
        //[Column("id_anuncio", TypeName = "Varchar50", Order = 2)]
        public int IdAnuncio { get; set; }

        //[Required]
        //[Column("url", TypeName = "Varchar50", Order = 3)]
        public string Url { get; set; }

    }
}