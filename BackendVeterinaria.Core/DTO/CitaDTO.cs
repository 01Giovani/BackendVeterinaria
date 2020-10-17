using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.DTO
{
   public class CitaDTO
    {
        public Guid Codigo { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Guid IdCliente { get; set; }
        public string MotivoConsulta { get; set; }

    }
}
