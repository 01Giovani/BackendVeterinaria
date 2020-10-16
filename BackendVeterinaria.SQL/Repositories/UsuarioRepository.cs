using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Repositories
{
    public class UsuarioRepository: IUsuarioRepository
    {


        private VeterinariaContext _db;
        public UsuarioRepository(VeterinariaContext db)
        {
            _db = db;
        }

        public List<Usuario> GetUsuarios()
        {
            return _db.Usuarios.AsNoTracking().ToList();
        }

        public Usuario GetUsuario(String id)
        {
            return _db.Usuarios.AsNoTracking().FirstOrDefault(result => result.IdUsuario == id);
        }

        public void EliminarUsuario(String id)
        {
            Usuario usuario = _db.Usuarios.FirstOrDefault(x => x.IdUsuario == id);
            if (usuario != null)
            {

                _db.Usuarios.Remove(usuario);
                _db.SaveChanges();
            }
        }

        public Usuario GuardarNuevoUsuario(Usuario usuario)
        {
            _db.Usuarios.Add(usuario);
            _db.SaveChanges();

            return usuario;
        }


        public Usuario EditarUsuario(Usuario usuario)
        {

            Usuario usuarioRemoto = _db.Usuarios.FirstOrDefault(x => x.IdUsuario == usuario.IdUsuario);
            if (usuarioRemoto != null)
            {
                usuarioRemoto.Nombre = usuario.Nombre;
                usuarioRemoto.Apellido = usuario.Apellido;
                usuarioRemoto.FechaIngreso = usuario.FechaIngreso;
                usuarioRemoto.Activo = usuario.Activo;
                usuarioRemoto.Contrasena = usuario.Contrasena;

                _db.SaveChanges();
            }

            return usuarioRemoto; 
        }
    }
}
