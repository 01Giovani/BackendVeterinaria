using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.DTO
{
    public class ServicioDTO
    {
        public Guid Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string TipoServicio { get; set; }
        public string Periocidad { get; set; }
        public bool Activo { get; set; }
        public decimal Precio { get; set; }
        //public virtual List<ConsultaDTO> Consultas { get; set; }
    }
}
