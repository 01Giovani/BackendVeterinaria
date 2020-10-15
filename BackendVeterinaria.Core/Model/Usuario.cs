using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Model
{
    public class Usuario
    {
        public Usuario()
        {
            this.Roles = new List<Rol>();
        }

        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public System.DateTime UltimoLogin { get; set; }
        public bool Activo { get; set; }
        public byte[] Contrasena { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual ICollection<Rol> Roles { get; set; }
    }
}
