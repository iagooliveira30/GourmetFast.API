using GourmetFast.Core.DTO;
using GourmetFast.Core.Entidades;
using GourmetFast.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetFast.Services.Services
{
    public class UsuarioService : IUsuarioService
    {

        private readonly List<Usuario> _usuario = new List<Usuario>();
        public IEnumerable<Usuario> FindAll()
        {
            return _usuario;
        }

        public void CreateUsuario(UsuarioDTO usuarioDTO)
        {
            if (usuarioDTO is null)
            {
                throw new ArgumentNullException("Usuário não pode ser nulo!");
            }

            var usuario = new Usuario();
            _usuario.Add(usuario);
        }
        public void UpdateUsuario(Guid id, UsuarioDTO novoUsuario)
        {
            var usuario = _usuario.Find(u => u.Id.Equals(id));

            if (usuario == null)
            {
                usuario.Id = id;
                usuario.Name = novoUsuario.Name;
                usuario.Email = novoUsuario.Email;
                usuario.Telefone = novoUsuario.Telefone;
                usuario.Endereco = novoUsuario.Endereco;
            }
        }
        //public Usuario ParaEntidade(UsuarioDTO usuarioDTO)
        //{
        //    ///var usuario = new Usuario(usuarioDTO); 
        //    return usuario;

        //}

    }
}
