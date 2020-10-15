using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Mapping
{
    public class ServicioMap : EntityTypeConfiguration<Servicio>
    {
        public ServicioMap()
        {
            // Primary Key
            this.HasKey(t => t.Codigo);

            // Properties
            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Descripcion)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.TipoServicio)
                .IsRequired();

            this.Property(t => t.Periocidad)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Servicio");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.Descripcion).HasColumnName("Descripcion");
            this.Property(t => t.TipoServicio).HasColumnName("TipoServicio");
            this.Property(t => t.Periocidad).HasColumnName("Periocidad");
            this.Property(t => t.Activo).HasColumnName("Activo");
            this.Property(t => t.Precio).HasColumnName("Precio");
        }
    }
}
