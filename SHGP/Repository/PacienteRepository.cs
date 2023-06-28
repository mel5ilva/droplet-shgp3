using Dapper;
using SHGP.Model;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SHGP.Controllers
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly string _connectionString;

        public PacienteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Paciente> GetPaciente()
        {
            var sql = "SELECT * FROM Paciente";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Paciente>(sql);
            }
        }

        public IEnumerable<Paciente> GetPacienteById(int id)
        {
            var sql = "SELECT * FROM Paciente WHERE ID_paciente = @ID_paciente";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Paciente>(sql, new { ID_paciente = id });
            }
        }

        public bool CreatePaciente(Paciente paciente)
        {
            var sql = @"INSERT INTO Paciente (ID_usuario, Nif) 
                        VALUES (@ID_usuario, @Nif);
                      ";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, paciente);
                return rowsAffected > 0;
            }
        }

        public bool UpdatePaciente(Paciente paciente)
        {
            var sql = @"UPDATE Paciente 
                        SET ID_usuario = @ID_usuario, Nif = @Nif 
                        WHERE ID_paciente = @ID_paciente";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, paciente);
                return rowsAffected > 0;
            }
        }

        public bool DeletePaciente(int id)
        {
            var sql = "DELETE FROM Paciente WHERE ID_paciente = @ID_paciente";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, new { ID_paciente = id });
                return rowsAffected > 0;
            }
        }
    }
}
