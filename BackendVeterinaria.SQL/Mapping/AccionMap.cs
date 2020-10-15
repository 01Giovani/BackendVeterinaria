using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Mapping
{
    public class AccionMap : EntityTypeConfiguration<Accion>
    {
        public AccionMap()
        {
            // Primary Key
            this.HasKey(t => t.Codigo);

            // Properties
            this.Property(t => t.Codigo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Accion");
            this.Property(t => t.Codigo).HasColumnName("Accion");
            this.Property(t => t.Nombre).HasColumnName("Nombre");

            // Relationships
            this.HasMany(t => t.Roles)
                .WithMany(t => t.Acciones)
                .Map(m =>
                {
                    m.ToTable("RolAccion");
                    m.MapLeftKey("Accion");
                    m.MapRightKey("Rol");
                });


        }
    }
}
