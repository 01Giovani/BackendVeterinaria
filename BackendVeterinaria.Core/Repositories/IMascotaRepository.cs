using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Repositories
{
    public interface IMascotaRepository
    {
        List<Mascota> GetMascotas();
        Mascota GetMascota(Guid id);
        void EliminarMascota(Guid id);
        Mascota GuardarNuevaMascota(Mascota mascota);
        Mascota EditarMascota(Mascota mascota);
        List<Mascota> GetMascotasCliente(Guid idCliente);
    }
}
