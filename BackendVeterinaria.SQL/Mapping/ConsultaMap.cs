using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Mapping
{
    public class ConsultaMap : EntityTypeConfiguration<Consulta>
    {
        public ConsultaMap()
        {
            // Primary Key
            this.HasKey(t => t.Codigo);

            // Properties
            this.Property(t => t.IdMedico)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Consulta");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Fecha).HasColumnName("Fecha");
            this.Property(t => t.IdMascota).HasColumnName("IdMascota");
            this.Property(t => t.IdMedico).HasColumnName("IdMedico");
            this.Property(t => t.Dictamen).HasColumnName("Dictamen");
            this.Property(t => t.IdCita).HasColumnName("IdCita");

            // Relationships
            this.HasMany(t => t.Servicios)
                .WithMany(t => t.Consultas)
                .Map(m =>
                {
                    m.ToTable("ServicioConsulta");
                    m.MapLeftKey("IdConsulta");
                    m.MapRightKey("IdServicio");
                });

            this.HasOptional(t => t.Cita)
                .WithMany(t => t.Consultas)
                .HasForeignKey(d => d.IdCita);
            this.HasRequired(t => t.Empleado)
                .WithMany(t => t.Consultas)
                .HasForeignKey(d => d.IdMedico);
            this.HasRequired(t => t.Mascota)
                .WithMany(t => t.Consultas)
                .HasForeignKey(d => d.IdMascota);

        }
    }
}
