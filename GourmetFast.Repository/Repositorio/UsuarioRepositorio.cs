using GourmetFast.Core.Entidades;
using GourmetFast.Repository.Context;
using GourmetFast.Repository.Interfaces;

namespace GourmetFast.Repository.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        
        private readonly ApplicationDbContext _context;

        public UsuarioRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Usuario> FindAll()
        {
            return _context.Usuarios.ToList();
        }
    }
}