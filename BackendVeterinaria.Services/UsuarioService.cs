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
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;
        public UsuarioService(
            IUsuarioRepository usuarioRepository
            )
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario EditarUsuario(Usuario usuario)
        {
            return _usuarioRepository.EditarUsuario(usuario);
        }

        public void EliminarUsuario(string id)
        {
            _usuarioRepository.EliminarUsuario(id);
        }

        public Usuario GetUsuario(string id)
        {
            return _usuarioRepository.GetUsuario(id);
        }

        public List<Usuario> GetUsuarios()
        {
            return _usuarioRepository.GetUsuarios();
        }

        public Usuario GuardarNuevoUsuario(Usuario usuario)
        {
            return _usuarioRepository.GuardarNuevoUsuario(usuario);
        }
    }
}
