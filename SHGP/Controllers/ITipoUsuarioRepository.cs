using SHGP.Model;
using SHGP.Repository;

namespace SHGP.Controllers
{
    public interface ITipoUsuarioRepository
    {
        public IEnumerable<TipoUsuario> GetTipoUsuario()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<TipoUsuario> GetTipoUsuarioById(int id)
        {
            throw new NotImplementedException();
        }
        public bool CreateTipoUsuario(TipoUsuario TipoUsuario)
        {
            throw new NotImplementedException();
        }
        public bool UpdateTipoUsuario(TipoUsuario TipoUsuario)
        {
            throw new NotImplementedException();
        }
        public bool DeleteTipoUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
