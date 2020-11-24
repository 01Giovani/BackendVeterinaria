using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Model
{
    public class Cliente
    {
        public Cliente()
        {
            this.Mascotas = new List<Mascota>();
        }

        public System.Guid Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Mascota> Mascotas { get; set; }
        public virtual ICollection<Cita> Citas { get; set; }
    }
}
