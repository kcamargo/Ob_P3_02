using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Ob_P3_02.Models
{
    public class BienvenidosUyContext: DbContext
    {
        public DbSet<Alojamiento> Alojamientos { get; set; }

        public DbSet<Anuncio> Anuncios { get; set; }

        public DbSet<Foto> Fotos { get; set; }

        public DbSet<Reserva> Reservas { get; set; }

        public DbSet<Servicio> Servicios { get; set; }

        public DbSet<Temporada> Temporadas { get; set; }

        public DbSet<TipoAlojamiento> TipoAlojamientos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public BienvenidosUyContext():base("con"){

        }



    }
}