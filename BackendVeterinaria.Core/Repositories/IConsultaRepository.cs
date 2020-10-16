using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Repositories
{
    public interface IConsultaRepository
    {
        List<Consulta> GetConsulta();
        Consulta GetConsulta(Guid id);
        void EliminarConsulta(Guid id);
        Consulta GuardarNuevoConsulta(Consulta consulta);
        Consulta EditarConsulta(Consulta consulta);
    }
}
