using SHGP.Model;

using SHGP.Repository;
namespace SHGP.Controllers
{
    public interface IAgendaRepository
    {
        public IEnumerable<Agenda> GetAgendas()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Agenda> GetAgendaById(int id)
        {
            throw new NotImplementedException();
        }
        public bool CreateAgenda(Agenda Agenda)
        {
            throw new NotImplementedException();
        }
        public bool UpdateAgenda(Agenda Agenda)
        {
            throw new NotImplementedException();
        }
        public bool DeleteAgenda(int id)
        {
            throw new NotImplementedException();
        }

    }
}
