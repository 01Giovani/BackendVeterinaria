using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Services
{
    public interface IUsuarioService
    {
        List<Usuario> GetUsuarios();
        Usuario GetUsuario(String id);
        void EliminarUsuario(String id);
        Usuario GuardarNuevoUsuario(Usuario usuario);
        Usuario EditarUsuario(Usuario usuario);
    }
}
