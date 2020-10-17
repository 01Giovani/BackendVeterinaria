using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.DTO
{
    public class FacturaDTO
    {
        public Guid Codigo { get; set; }
        public Guid Idconsulta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }


    }
}
