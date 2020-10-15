using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Mapping
{
    public class RolMap : EntityTypeConfiguration<Rol>
    {
        public RolMap()
        {
            // Primary Key
            this.HasKey(t => t.Codigo);

            // Properties
            this.Property(t => t.Codigo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Rol");
            this.Property(t => t.Codigo).HasColumnName("Rol");
            this.Property(t => t.Descripcion).HasColumnName("Descripcion");

            // Relationships
            this.HasMany(t => t.Usuarios)
                .WithMany(t => t.Roles)
                .Map(m =>
                {
                    m.ToTable("RolUsuario");
                    m.MapLeftKey("Rol");
                    m.MapRightKey("Usuario");
                });


        }
    }
}
