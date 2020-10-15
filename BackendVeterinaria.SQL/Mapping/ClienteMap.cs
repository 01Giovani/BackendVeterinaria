using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.Codigo);

            // Properties
            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Apellido)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Direccion)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.Telefono)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Cliente");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.Apellido).HasColumnName("Apellido");
            this.Property(t => t.Direccion).HasColumnName("Direccion");
            this.Property(t => t.Telefono).HasColumnName("Telefono");
            this.Property(t => t.Email).HasColumnName("Email");
        }
    }
}
