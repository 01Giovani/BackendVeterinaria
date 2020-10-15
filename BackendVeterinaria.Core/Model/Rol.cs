using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Model
{
    public class Rol
    {
        public Rol()
        {
            this.Acciones = new List<Accion>();
            this.Usuarios = new List<Usuario>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Accion> Acciones { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
