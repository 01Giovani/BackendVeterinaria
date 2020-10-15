using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Model
{
    public class Servicio
    {
        public Servicio()
        {
            this.Consultas = new List<Consulta>();
        }

        public System.Guid Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TipoServicio TipoServicio { get; set; }
        public string Periocidad { get; set; }
        public bool Activo { get; set; }
        public decimal Precio { get; set; }
        public virtual ICollection<Consulta> Consultas { get; set; }
    }

    public enum TipoServicio{ 
        /// <summary>
        /// Servicio programado
        /// </summary>
        Periodico= 1,
        /// <summary>
        /// servicio no programado
        /// </summary>
        UnaVez = 2
    }
}
