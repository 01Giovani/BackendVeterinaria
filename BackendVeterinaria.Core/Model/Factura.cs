using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Model
{
    public class Factura
    {
        public System.Guid Codigo { get; set; }
        public System.Guid IdConsulta { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public virtual Consulta Consulta { get; set; }
    }
}
