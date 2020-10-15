namespace BackendVeterinaria.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accion",
                c => new
                    {
                        Accion = c.String(nullable: false, maxLength: 500),
                        Nombre = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Accion);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        Rol = c.String(nullable: false, maxLength: 20),
                        Descripcion = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Rol);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Usuario = c.String(nullable: false, maxLength: 50),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Apellido = c.String(nullable: false, maxLength: 100),
                        FechaIngreso = c.DateTime(nullable: false),
                        UltimoLogin = c.DateTime(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        Contrasena = c.Binary(nullable: false, maxLength: 16, fixedLength: true),
                    })
                .PrimaryKey(t => t.Usuario)
                .ForeignKey("dbo.Empleado", t => t.Usuario)
                .Index(t => t.Usuario);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        Usuario = c.String(nullable: false, maxLength: 50),
                        Direccion = c.String(nullable: false, maxLength: 150),
                        Telefono = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Usuario);
            
            CreateTable(
                "dbo.Consulta",
                c => new
                    {
                        Codigo = c.Guid(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        IdMascota = c.Guid(nullable: false),
                        IdMedico = c.String(nullable: false, maxLength: 50),
                        Dictamen = c.String(),
                        IdCita = c.Guid(),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Cita", t => t.IdCita)
                .ForeignKey("dbo.Empleado", t => t.IdMedico, cascadeDelete: true)
                .ForeignKey("dbo.Mascota", t => t.IdMascota, cascadeDelete: true)
                .Index(t => t.IdMascota)
                .Index(t => t.IdMedico)
                .Index(t => t.IdCita);
            
            CreateTable(
                "dbo.Cita",
                c => new
                    {
                        Codigo = c.Guid(nullable: false),
                        FechaReservada = c.DateTime(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false),
                        IdCliente = c.Guid(nullable: false),
                        MotivoConsulta = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        Codigo = c.Guid(nullable: false),
                        IdConsulta = c.Guid(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Consulta", t => t.IdConsulta, cascadeDelete: true)
                .Index(t => t.IdConsulta);
            
            CreateTable(
                "dbo.Mascota",
                c => new
                    {
                        Codigo = c.Guid(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Especie = c.String(nullable: false, maxLength: 50),
                        Raza = c.String(maxLength: 50),
                        Color = c.String(maxLength: 50),
                        Tamaño = c.String(maxLength: 50),
                        IdCliente = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Cliente", t => t.IdCliente, cascadeDelete: true)
                .Index(t => t.IdCliente);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Codigo = c.Guid(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        Direccion = c.String(nullable: false, maxLength: 150),
                        Telefono = c.String(nullable: false, maxLength: 20),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Servicio",
                c => new
                    {
                        Codigo = c.Guid(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(nullable: false, maxLength: 150),
                        TipoServicio = c.Int(nullable: false),
                        Periocidad = c.String(maxLength: 50),
                        Activo = c.Boolean(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.ServicioConsulta",
                c => new
                    {
                        IdConsulta = c.Guid(nullable: false),
                        IdServicio = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdConsulta, t.IdServicio })
                .ForeignKey("dbo.Consulta", t => t.IdConsulta, cascadeDelete: true)
                .ForeignKey("dbo.Servicio", t => t.IdServicio, cascadeDelete: true)
                .Index(t => t.IdConsulta)
                .Index(t => t.IdServicio);
            
            CreateTable(
                "dbo.RolUsuario",
                c => new
                    {
                        Rol = c.String(nullable: false, maxLength: 20),
                        Usuario = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.Rol, t.Usuario })
                .ForeignKey("dbo.Rol", t => t.Rol, cascadeDelete: true)
                .ForeignKey("dbo.Usuario", t => t.Usuario, cascadeDelete: true)
                .Index(t => t.Rol)
                .Index(t => t.Usuario);
            
            CreateTable(
                "dbo.RolAccion",
                c => new
                    {
                        Accion = c.String(nullable: false, maxLength: 500),
                        Rol = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => new { t.Accion, t.Rol })
                .ForeignKey("dbo.Accion", t => t.Accion, cascadeDelete: true)
                .ForeignKey("dbo.Rol", t => t.Rol, cascadeDelete: true)
                .Index(t => t.Accion)
                .Index(t => t.Rol);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolAccion", "Rol", "dbo.Rol");
            DropForeignKey("dbo.RolAccion", "Accion", "dbo.Accion");
            DropForeignKey("dbo.RolUsuario", "Usuario", "dbo.Usuario");
            DropForeignKey("dbo.RolUsuario", "Rol", "dbo.Rol");
            DropForeignKey("dbo.Usuario", "Usuario", "dbo.Empleado");
            DropForeignKey("dbo.ServicioConsulta", "IdServicio", "dbo.Servicio");
            DropForeignKey("dbo.ServicioConsulta", "IdConsulta", "dbo.Consulta");
            DropForeignKey("dbo.Consulta", "IdMascota", "dbo.Mascota");
            DropForeignKey("dbo.Mascota", "IdCliente", "dbo.Cliente");
            DropForeignKey("dbo.Factura", "IdConsulta", "dbo.Consulta");
            DropForeignKey("dbo.Consulta", "IdMedico", "dbo.Empleado");
            DropForeignKey("dbo.Consulta", "IdCita", "dbo.Cita");
            DropIndex("dbo.RolAccion", new[] { "Rol" });
            DropIndex("dbo.RolAccion", new[] { "Accion" });
            DropIndex("dbo.RolUsuario", new[] { "Usuario" });
            DropIndex("dbo.RolUsuario", new[] { "Rol" });
            DropIndex("dbo.ServicioConsulta", new[] { "IdServicio" });
            DropIndex("dbo.ServicioConsulta", new[] { "IdConsulta" });
            DropIndex("dbo.Mascota", new[] { "IdCliente" });
            DropIndex("dbo.Factura", new[] { "IdConsulta" });
            DropIndex("dbo.Consulta", new[] { "IdCita" });
            DropIndex("dbo.Consulta", new[] { "IdMedico" });
            DropIndex("dbo.Consulta", new[] { "IdMascota" });
            DropIndex("dbo.Usuario", new[] { "Usuario" });
            DropTable("dbo.RolAccion");
            DropTable("dbo.RolUsuario");
            DropTable("dbo.ServicioConsulta");
            DropTable("dbo.Servicio");
            DropTable("dbo.Cliente");
            DropTable("dbo.Mascota");
            DropTable("dbo.Factura");
            DropTable("dbo.Cita");
            DropTable("dbo.Consulta");
            DropTable("dbo.Empleado");
            DropTable("dbo.Usuario");
            DropTable("dbo.Rol");
            DropTable("dbo.Accion");
        }
    }
}
