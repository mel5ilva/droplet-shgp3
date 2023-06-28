using Dapper;
using SHGP.Controllers;
using SHGP.Model;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SHGP.Repository
{
    public class ConsultaRepository : IConsultaRepository 
    {
        
        private readonly string _connectionString;

        public ConsultaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Consulta> GetConsultas()
        {
            var sql = "SELECT * FROM Consultas";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Consulta>(sql);
            }
        }

        public IEnumerable<Consulta> GetConsultasbyId(int id)
        {
            var sql = "SELECT * FROM Consultas WHERE ID_consulta = @ID";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Consulta>(sql, new { ID = id });
            }
        }

        public IEnumerable<Consulta> GetConsultaPaciente(int id)
        {
            var sql = "SELECT * FROM Consultas WHERE ID_paciente = @ID";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Consulta>(sql, new { ID = id });
            }
        }

        public IEnumerable<Consulta> GetConsultaMedico(int id)
        {
            var sql = "SELECT * FROM Consultas WHERE ID_medico = @ID";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Consulta>(sql, new { ID = id });
            }
        }

        public bool CreateConsulta(Consulta consulta)
        {
            int insertedId;

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                string query = @"INSERT INTO Consultas (ID_medico, ID_especialidade, ID_paciente, ID_agendamento, diagnostico, preco)
                                 VALUES (@IDMedico, @IDEspecialidade, @IDPaciente, @IDAgendamento, @Diagnostico, @Preco);
                                 SELECT SCOPE_IDENTITY();";

                insertedId = connection.ExecuteScalar<int>(query, consulta);
            }

            return insertedId > 0;
        }
   
        public bool UpdateConsulta(Consulta consulta)
        {
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                string query = @"UPDATE Consultas SET ID_medico = @ID_medico, ID_especialidade = @ID_especialidade, 
                                 ID_paciente = @ID_paciente, ID_agendamento = @ID_agendamento, diagnostico = @diagnostico, preco = @preco
                                 WHERE ID_consulta = @ID_consulta";

                int rowsAffected = connection.Execute(query, consulta);

                return rowsAffected > 0;
            }
        }

        public bool DeleteConsulta(int id)
        {
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                string query = "DELETE FROM Consultas WHERE ID_consulta = @Id";

                int rowsAffected = connection.Execute(query, new { Id = id });

                return rowsAffected > 0;
            }
        }
    }
}
