using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Model
{
    public class Accion
    {
        public Accion()
        {
            this.Roles = new List<Rol>();
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Rol> Roles { get; set; }
    }
}
