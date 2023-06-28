using SHGP.Model;
using SHGP.Repository;

namespace SHGP.Controllers
{
    public interface IPacienteRepository
    {
        public IEnumerable<Paciente> GetPaciente()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Paciente> GetPacienteById(int id)
        {
            throw new NotImplementedException();
        }
        public bool CreatePaciente(Paciente Paciente)
        {
            throw new NotImplementedException();
        }
        public bool UpdatePaciente(Paciente Paciente)
        {
            throw new NotImplementedException();
        }
        public bool DeletePaciente(int id)
        {
            throw new NotImplementedException();
        }
    }
}
