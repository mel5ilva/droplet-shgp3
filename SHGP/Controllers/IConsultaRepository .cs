using SHGP.Model;

namespace SHGP.Controllers
{
    public interface IConsultaRepository
    {
        public IEnumerable<Consulta> GetConsultas()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Consulta> GetConsultaByPaciente(int id)
        {
            throw new NotImplementedException();
        }
       
         public IEnumerable<Consulta> GetConsultaByMedico(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Consulta> GetConsultasbyId(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Consulta> GetConsultaPaciente(int id_user)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Consulta> GetConsultaMedico(int id_user)
        {
            throw new NotImplementedException();
        }
        public bool CreateConsulta(Consulta consulta)
        {
            throw new NotImplementedException();
        }
        public bool UpdateConsulta(Consulta consulta)
        {
            throw new NotImplementedException();
        }
        public bool DeleteConsulta(int id)
        {
            throw new NotImplementedException();
        }
    }
}
