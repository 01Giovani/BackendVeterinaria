using BackendVeterinaria.Core.Model;
using BackendVeterinaria.SQL.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL
{
    public partial class VeterinariaContext : DbContext
    {
        static VeterinariaContext()
        {
            Database.SetInitializer<VeterinariaContext>(null);
        }

        public VeterinariaContext()
            : base("Name=VeterinariaContext")
        {
        }

        public DbSet<Accion> Acciones { get; set; } 
        public DbSet<Cita> Citas { get; set; } 
        public DbSet<Cliente> Clientes { get; set; } 
        public DbSet<Consulta> Consultas { get; set; } 
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Factura> Facturas { get; set; } 
        public DbSet<Mascota> Mascotas { get; set; } 
        public DbSet<Rol> Roles { get; set; } 
        public DbSet<Servicio> Servicios { get; set; }     
        public DbSet<Usuario> Usuarios { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AccionMap());
            modelBuilder.Configurations.Add(new CitaMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new ConsultaMap());
            modelBuilder.Configurations.Add(new EmpleadoMap());
            modelBuilder.Configurations.Add(new FacturaMap());
            modelBuilder.Configurations.Add(new MascotaMap());
            modelBuilder.Configurations.Add(new RolMap());
            modelBuilder.Configurations.Add(new ServicioMap());            
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}
