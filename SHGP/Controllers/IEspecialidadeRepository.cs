using SHGP.Model;

namespace SHGP.Controllers
{
    public interface IEspecialidadeRepository

    {
        public IEnumerable<Especialidade> GetEspecialidades()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Especialidade> GetEspecialidadeById(int id)
        {
            throw new NotImplementedException();
        }
        public bool CreateEspecialidade(Especialidade Especialidade)
        {
            throw new NotImplementedException();
        }
        public bool UpdateEspecialidade(Especialidade Especialidade)
        {
            throw new NotImplementedException();
        }
        public bool DeleteEspecialidade(int id)
        {
            throw new NotImplementedException();
        }
    }
}
