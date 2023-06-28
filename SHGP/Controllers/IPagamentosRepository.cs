using SHGP.Model;
using SHGP.Repository;

namespace SHGP.Controllers
{
    public interface IPagamentosRepository
    {
        public IEnumerable<Pagamentos> GetPagamentos()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Pagamentos> GetPagamentosById(int id)
        {
            throw new NotImplementedException();
        }
        public bool CreatePagamentos(Pagamentos Pagamentos)
        {
            throw new NotImplementedException();
        }
        public bool UpdatePagamentos(Pagamentos Pagamentos)
        {
            throw new NotImplementedException();
        }
        public bool DeletePagamentos(int id)
        {
            throw new NotImplementedException();
        }
    }
}
