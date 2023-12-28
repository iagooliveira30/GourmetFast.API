using GourmetFast.Core.Entidades;

namespace GourmetFast.Repository.Interfaces
{
    public interface IUsuarioRepositorio
    {
        IList<Usuario> FindAll();

    }
}
