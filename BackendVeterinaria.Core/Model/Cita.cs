using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Model
{
    public class Cita
    {
        public Cita()
        {
            this.Consultas = new List<Consulta>();
        }

        public System.Guid Codigo { get; set; }
        public System.DateTime FechaReservada { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public System.Guid IdCliente { get; set; }
        public string MotivoConsulta { get; set; }
        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}
