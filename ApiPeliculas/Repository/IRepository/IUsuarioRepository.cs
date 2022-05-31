using ApiPeliculas.Models;
using System.Collections.Generic;

namespace ApiPeliculas.Repository.IRepository
{
    public interface IUsuarioRepository
    {
        ICollection<Usuario> GetUsuarios();
        Usuario GetUsuario(int usuarioId);
        bool ExisteUsuario(string nombre);
        Usuario Registro(Usuario usuario, string password);
        Usuario Login(string usuario, string password);
        bool BorrarUsuario(Usuario usuario);
        bool Guardar();
    }
}
