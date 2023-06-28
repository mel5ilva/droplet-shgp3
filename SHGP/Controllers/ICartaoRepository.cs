using SHGP.Model;

namespace SHGP.Controllers
{
    public interface ICartaoRepository
    {
        public IEnumerable<Cartao> GetCartao()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Cartao> GetCartaoById(int id)
        {
            throw new NotImplementedException();
        }
        public bool CreateCartao(Cartao Cartao)
        {
            throw new NotImplementedException();
        }
        public bool UpdateCartao(Cartao Cartao)
        {
            throw new NotImplementedException();
        }
        public bool DeleteCartao(int id)
        {
            throw new NotImplementedException();
        }
    }
}
