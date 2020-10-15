using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Model
{
    public class Mascota
    {
        public Mascota()
        {
            this.Consultas = new List<Consulta>();
        }

        public System.Guid Codigo { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }
        public string Tamaño { get; set; }
        public System.Guid IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}
