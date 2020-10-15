using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Mapping
{
    public class MascotaMap : EntityTypeConfiguration<Mascota>
    {
        public MascotaMap()
        {
            // Primary Key
            this.HasKey(t => t.Codigo);

            // Properties
            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Especie)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Raza)
                .HasMaxLength(50);

            this.Property(t => t.Color)
                .HasMaxLength(50);

            this.Property(t => t.Tamaño)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Mascota");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.Especie).HasColumnName("Especie");
            this.Property(t => t.Raza).HasColumnName("Raza");
            this.Property(t => t.Color).HasColumnName("Color");
            this.Property(t => t.Tamaño).HasColumnName("Tamaño");
            this.Property(t => t.IdCliente).HasColumnName("IdCliente");

            // Relationships
            this.HasRequired(t => t.Cliente)
                .WithMany(t => t.Mascotas)
                .HasForeignKey(d => d.IdCliente);

        }
    }
}
