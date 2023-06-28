using Dapper;
using MySql.Data.MySqlClient;
using SHGP.Model;


namespace SHGP.Controllers
{
    public class AgendamentoRepository: IAgendamentoRepository
    {
        private readonly string _connectionString;

        public AgendamentoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Agendamento> GetAgendamentos()
        {
            var sql = "SELECT * FROM Agendamento";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Agendamento>(sql);
            }
        }
        public IEnumerable<Agendamento> GetAgendamentoById(int id)
        {
            var sql = "SELECT * FROM `Agendamento` WHERE `ID_agendamento` = '" + id + "'";
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Agendamento>(sql);
            }
        }
       

        public bool CreateAgendamento(Agendamento Agendamento)
        {
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Agendamento (ID_medico, ID_paciente, DataAgendada, HoraInicial, HoraFinal, Descricao) VALUES (@ID_medico, @ID_paciente, @DataAgendada, @HoraInicial, @HoraFinal, @Descricao);";
                int rowsAffected = connection.Execute(sql, Agendamento);

                return rowsAffected > 0;
            }
        }
        public bool UpdateAgendamento(Agendamento Agendamento)
        {
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                connection.Open();

                string sql = "UPDATE Agendamento SET ID_medico = @ID_medico,ID_paciente = @ID_paciente,DataAgendada = @DataAgendada,HoraInicial = @HoraInicial, HoraFinal = @HoraFinal, Descricao = @Descricao WHERE ID_agendamento = @ID_agendamento;";
                int rowsAffected = connection.Execute(sql, Agendamento);

                return rowsAffected > 0;
            }
        }

        public bool DeleteAgendamento(int id)
        {
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM Agendamentos WHERE ID_agendamento = @ID_agendamento";
                int rowsAffected = connection.Execute(sql, new { ID_agendamento = id });

                return rowsAffected > 0;
            }
        }


    }
}
