using SHGP.Model;
using SHGP.Repository;

namespace SHGP.Controllers
{
    public interface IReceitasMedicasRepository
    {
        public IEnumerable<ReceitasMedicas> GetReceitasMedicas()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<ReceitasMedicas> GetReceitasMedicasById(int id)
        {
            throw new NotImplementedException();
        }
        public bool CreateReceitasMedicas(ReceitasMedicas ReceitasMedicas)
        {
            throw new NotImplementedException();
        }
        public bool UpdateReceitasMedicas(ReceitasMedicas ReceitasMedicas)
        {
            throw new NotImplementedException();
        }
        public bool DeleteReceitasMedicas(int id)
        {
            throw new NotImplementedException();
        }
    }
}
