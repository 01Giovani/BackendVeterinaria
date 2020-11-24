using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Services
{
    public interface IConsultaService
    {
        List<Cita> GetCitasSinConsulta();
    }
}
