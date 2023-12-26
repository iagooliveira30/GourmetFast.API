using GourmetFast.Core.DTO;
using GourmetFast.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetFast.Services.Interfaces
{
    public interface IUsuarioService
    {
        IEnumerable<Usuario> FindAll();
        void CreateUsuario(UsuarioDTO usuarioDTO);
        void UpdateUsuario(Guid id, UsuarioDTO novoUsuario);

    }
}
