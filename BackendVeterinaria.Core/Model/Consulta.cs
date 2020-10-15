using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Model
{
    public class Consulta
    {
        public Consulta()
        {
            this.Facturas = new List<Factura>();
            this.Servicios = new List<Servicio>();
        }

        public System.Guid Codigo { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.Guid IdMascota { get; set; }
        public string IdMedico { get; set; }
        public string Dictamen { get; set; }
        public Nullable<System.Guid> IdCita { get; set; }
        public virtual Cita Cita { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Mascota Mascota { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
