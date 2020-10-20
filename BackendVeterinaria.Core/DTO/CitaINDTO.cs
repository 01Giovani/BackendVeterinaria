
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.DTO
{
    public class CitaINDTO
    {
        public Guid Codigo { get; set; }
        public string FechaReserva { get; set; }        
        public Guid IdCliente { get; set; }
        public string MotivoConsulta { get; set; }
    }
}
