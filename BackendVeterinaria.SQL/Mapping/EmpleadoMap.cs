using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Mapping
{
    public class EmpleadoMap : EntityTypeConfiguration<Empleado>
    {
        public EmpleadoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUsuario);

            // Properties
            this.Property(t => t.IdUsuario)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Direccion)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Telefono)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Empleado");
            this.Property(t => t.IdUsuario).HasColumnName("Usuario");
            this.Property(t => t.Direccion).HasColumnName("Direccion");
            this.Property(t => t.Telefono).HasColumnName("Telefono");
            this.Property(t => t.Email).HasColumnName("Email");
        }
    }
}
