using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Mapping
{
    public class CitaMap : EntityTypeConfiguration<Cita>
    {
        public CitaMap()
        {
            // Primary Key
            this.HasKey(t => t.Codigo);

            // Properties
            this.Property(t => t.MotivoConsulta)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Cita");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.FechaReservada).HasColumnName("FechaReservada");
            this.Property(t => t.FechaIngreso).HasColumnName("FechaIngreso");
            this.Property(t => t.IdCliente).HasColumnName("IdCliente");
            this.Property(t => t.MotivoConsulta).HasColumnName("MotivoConsulta");

            HasRequired(x => x.Cliente).WithMany(x => x.Citas).HasForeignKey(x => x.IdCliente);
        }
    }
}
