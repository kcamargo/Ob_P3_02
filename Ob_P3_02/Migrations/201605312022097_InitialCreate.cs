namespace Ob_P3_02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alojamiento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        TipoHabitacion = c.String(),
                        TipoBanio = c.String(),
                        CapacidadXPersona = c.Int(nullable: false),
                        Ciudad = c.String(),
                        Barrio = c.String(),
                        TipoAlojamiento_Id = c.Int(),
                        TipoDeServicios_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tipo_Alojamiento", t => t.TipoAlojamiento_Id)
                .ForeignKey("dbo.Servicio", t => t.TipoDeServicios_Id)
                .Index(t => t.TipoAlojamiento_Id)
                .Index(t => t.TipoDeServicios_Id);
            
            CreateTable(
                "dbo.Tipo_Alojamiento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Servicio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Anuncios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdAlojamiento = c.Int(nullable: false),
                        Direccion = c.String(),
                        NombreAnuncio = c.String(),
                        DescripcionAnuncio = c.String(),
                        PrecioBase = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Foto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdAnuncio = c.Int(nullable: false),
                        Url = c.String(),
                        Anuncio_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Anuncios", t => t.Anuncio_Id)
                .Index(t => t.Anuncio_Id);
            
            CreateTable(
                "dbo.Reserva",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        CantidadPersonas = c.Int(nullable: false),
                        PrecioTotal = c.Double(nullable: false),
                        HospedajeSelect_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Anuncios", t => t.HospedajeSelect_Id)
                .Index(t => t.HospedajeSelect_Id);
            
            CreateTable(
                "dbo.Temporada",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        Importe = c.Int(nullable: false),
                        Id_anuncio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rol = c.Int(nullable: false),
                        NombreUsuario = c.String(),
                        Email = c.String(),
                        ApellidoUsuario = c.String(),
                        Contrasena = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Foto = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reserva", "HospedajeSelect_Id", "dbo.Anuncios");
            DropForeignKey("dbo.Foto", "Anuncio_Id", "dbo.Anuncios");
            DropForeignKey("dbo.Alojamiento", "TipoDeServicios_Id", "dbo.Servicio");
            DropForeignKey("dbo.Alojamiento", "TipoAlojamiento_Id", "dbo.Tipo_Alojamiento");
            DropIndex("dbo.Reserva", new[] { "HospedajeSelect_Id" });
            DropIndex("dbo.Foto", new[] { "Anuncio_Id" });
            DropIndex("dbo.Alojamiento", new[] { "TipoDeServicios_Id" });
            DropIndex("dbo.Alojamiento", new[] { "TipoAlojamiento_Id" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Temporada");
            DropTable("dbo.Reserva");
            DropTable("dbo.Foto");
            DropTable("dbo.Anuncios");
            DropTable("dbo.Servicio");
            DropTable("dbo.Tipo_Alojamiento");
            DropTable("dbo.Alojamiento");
        }
    }
}
