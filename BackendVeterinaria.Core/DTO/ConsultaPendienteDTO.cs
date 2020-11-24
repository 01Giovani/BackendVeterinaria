using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.DTO
{
    public class ConsultaPendienteDTO
    {
        public string Cliente { get; set; }
        public string IdCita { get; set; }
        public string FechaCita { get; set; }
        public string Motivo { get; set; }

        public List<MascotasConsultaDTO> MascotasCliente { get; set; }
        public List<EmpleadoConsultaDTO> MedicosDisponibles { get; set; }
    }

    public class MascotasConsultaDTO
    {
        public Guid IdMascota { get; set; }
        public string NombreMascota { get; set; }
    }

    public class EmpleadoConsultaDTO
    {
        public string IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
    }
}
