using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Model
{
    public class Empleado
    {
        public Empleado()
        {
            this.Consultas = new List<Consulta>();
        }

        public string IdUsuario { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Consulta> Consultas { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
