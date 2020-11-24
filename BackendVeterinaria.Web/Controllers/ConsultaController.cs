using BackendVeterinaria.Core.DTO;
using BackendVeterinaria.Core.Repositories;
using BackendVeterinaria.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendVeterinaria.Web.Controllers
{
    public class ConsultaController : ApiController
    {
        private IMascotaRepository _mascotaRepository;
        private IEmpleadoRepository _empleadoRepository;
        private IConsultaService _consultaService;
        public ConsultaController(
            IConsultaService consultaService,
            IEmpleadoRepository empleadoRepository,
            IMascotaRepository mascotaRepository
            )
        {
            _consultaService = consultaService;
            _empleadoRepository = empleadoRepository;
            _mascotaRepository = mascotaRepository;
        }

        [Route("Api/Consulta/GetCitasPendientes")]
        public List<ConsultaPendienteDTO> GetCitasPendientes() {

            var mascotas = _mascotaRepository.GetMascotas();
            var empleados = _empleadoRepository.GetMedicos();
            var lista = _consultaService.GetCitasSinConsulta();


            List<ConsultaPendienteDTO> response = new List<ConsultaPendienteDTO>();

            response = lista.Select(x => new ConsultaPendienteDTO() { 
                Cliente = x.Cliente.Nombre+" "+x.Cliente.Apellido,
                FechaCita = x.FechaReservada.ToString("dd/MM/yyyy"), 
                IdCita = x.Codigo.ToString(), 
                Motivo = x.MotivoConsulta ,
                MascotasCliente = mascotas.Where(v=>v.IdCliente == x.IdCliente).Select(c=> new MascotasConsultaDTO() { IdMascota = x.Codigo,NombreMascota = c.Nombre }).ToList(),
                MedicosDisponibles = empleados.Select(c=> new EmpleadoConsultaDTO() {IdEmpleado = c.IdUsuario, NombreEmpleado = c.Usuario.Nombre+" "+ c.Usuario.Apellido }).ToList()
            }).OrderBy(x=>x.FechaCita).ToList();


            return response;
        }
    }
}
