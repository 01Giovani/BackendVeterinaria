using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Repositories;
using BackendVeterinaria.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Services
{
    public class ConsultaService : IConsultaService
    {
        private ICitaRepository _citaRepository;
        public ConsultaService(
            ICitaRepository citaRepository
            )
        {
            _citaRepository = citaRepository;
        }

        public List<Cita> GetCitasSinConsulta()
        {
            return _citaRepository.GetCitasSinConsulta();
        }
    }
}
