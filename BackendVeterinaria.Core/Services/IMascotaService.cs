using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackendVeterinaria.Core.Services
{
   public interface IMascotaService
    {
        List<Mascota> GetMascotas();
        Mascota GetMascota(Guid id);
        void EliminarMascota(Guid id);
        Mascota GuardarNuevaMascota(Mascota mascota);
        Mascota EditarMascota(Mascota mascota);

    }
}
