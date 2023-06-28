using Dapper;
using SHGP.Model;
using MySql.Data.MySqlClient;

namespace SHGP.Controllers
{
    public class AgendaRepository: IAgendaRepository
    {
        private readonly string _connectionString;

        public AgendaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Agenda> GetAgendas()
        {
            var sql = "SELECT * FROM Agenda";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Agenda>(sql);
            }
        }
        public IEnumerable<Agenda> GetAgendaById(int id)
        {
            var sql = "SELECT * FROM `Agenda` WHERE `ID_agenda` = '" + id + "'";
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Agenda>(sql);
            }
        }
        public bool CreateAgenda(Agenda Agenda)
        {
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Agenda (ID_medico, ID_paciente, DataAgendada, HoraInicial, HoraFinal, Descricao) VALUES (@ID_medico, @ID_paciente, @DataAgendada, @HoraInicial, @HoraFinal, @Descricao);";
                int rowsAffected = connection.Execute(sql, Agenda);

                return rowsAffected > 0;
            }
        }
        public bool UpdateAgenda(Agenda Agenda)
        {
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                connection.Open();

                string sql = "UPDATE Agenda SET ID_medico = @ID_medico,ID_paciente = @ID_paciente,DataAgendada = @DataAgendada,HoraInicial = @HoraInicial, HoraFinal = @HoraFinal, Descricao = @Descricao WHERE ID_Agenda = @ID_Agenda;";
                int rowsAffected = connection.Execute(sql, Agenda);

                return rowsAffected > 0;
            }
        }

        public bool DeleteAgenda(int id)
        {
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM Agendas WHERE ID_Agenda = @ID_Agenda";
                int rowsAffected = connection.Execute(sql, new { ID_Agenda = id });

                return rowsAffected > 0;
            }
        }

    }
}
