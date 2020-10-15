using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUsuario);

            // Properties
            this.Property(t => t.IdUsuario)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Apellido)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Contrasena)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("Usuario");
            this.Property(t => t.IdUsuario).HasColumnName("Usuario");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.Apellido).HasColumnName("Apellido");
            this.Property(t => t.FechaIngreso).HasColumnName("FechaIngreso");
            this.Property(t => t.UltimoLogin).HasColumnName("UltimoLogin");
            this.Property(t => t.Activo).HasColumnName("Activo");
            this.Property(t => t.Contrasena).HasColumnName("Contrasena");

            // Relationships
            this.HasRequired(t => t.Empleado)
                .WithOptional(t => t.Usuario);

        }
    }
}
