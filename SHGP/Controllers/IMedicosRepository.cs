using SHGP.Model;
using SHGP.Repository;

namespace SHGP.Controllers
{
    public interface IMedicosRepository
    {
        public IEnumerable<Medicos> GetMedicos()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Medicos> GetMedicosById(int id)
        {
            throw new NotImplementedException();
        }
        public bool CreateMedicos(Medicos Medicos)
        {
            throw new NotImplementedException();
        }
        public bool UpdateMedicos(Medicos Medicos)
        {
            throw new NotImplementedException();
        }
        public bool DeleteMedicos(int id)
        {
            throw new NotImplementedException();
        }
    }
}
