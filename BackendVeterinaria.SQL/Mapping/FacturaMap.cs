using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Mapping
{
    public class FacturaMap : EntityTypeConfiguration<Factura>
    {
        public FacturaMap()
        {
            // Primary Key
            this.HasKey(t => t.Codigo);

            // Properties
            // Table & Column Mappings
            this.ToTable("Factura");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.IdConsulta).HasColumnName("IdConsulta");
            this.Property(t => t.Fecha).HasColumnName("Fecha");
            this.Property(t => t.Total).HasColumnName("Total");

            // Relationships
            this.HasRequired(t => t.Consulta)
                .WithMany(t => t.Facturas)
                .HasForeignKey(d => d.IdConsulta);

        }
    }
}
