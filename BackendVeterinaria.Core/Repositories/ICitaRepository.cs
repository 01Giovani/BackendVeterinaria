using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Repositories
{
    public interface ICitaRepository
    {

        List<Cita> GetCitas();
        Cita GetCita(Guid id);
        void EliminarCita(Guid id);
        Cita GuardarNuevaCita(Cita cita);
        Cita EditarCita(Cita cita);
        List<Cita> GetCitasSinConsulta();


    }
}
