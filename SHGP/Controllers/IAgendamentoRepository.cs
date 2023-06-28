using SHGP.Model;

using SHGP.Repository;
namespace SHGP.Controllers
{
    public interface IAgendamentoRepository
    {
        public IEnumerable<Agendamento> GetAgendamentos()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Agendamento> GetAgendamentoById(int id)
        {
            throw new NotImplementedException();
        }
        public bool CreateAgendamento(Agendamento agendamento)
        {
            throw new NotImplementedException();
        }
        public bool UpdateAgendamento(Agendamento agendamento)
        {
            throw new NotImplementedException();
        }
        public bool DeleteAgendamento(int id)
        {
            throw new NotImplementedException();
        }

    }
}
