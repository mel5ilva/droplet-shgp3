using Dapper;
using SHGP.Model;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SHGP.Controllers
{
    public class ExamesRepository : IExamesRepository
    {
        private readonly string _connectionString;

        public ExamesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Exames> GetExames()
        {
            var sql = "SELECT * FROM Exames";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Exames>(sql);
            }
        }

        public IEnumerable<Exames> GetExamesById(int id)
        {
            var sql = "SELECT * FROM Exames WHERE ID_exames = @ID_exames";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Exames>(sql, id);
            }
        }

        public bool CreateExames(Exames exame)
        {
            var sql = @"INSERT INTO Exames (ID_paciente, ID_medico, tipoExame, urgencia) 
                        VALUES (@ID_paciente, @ID_medico, @tipoExame, @urgencia);
                       ";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, exame);
                return rowsAffected > 0;
            }
        }

        public bool UpdateExames(Exames exame)
        {
            var sql = @"UPDATE Exames 
                        SET ID_paciente = @ID_paciente, ID_medico = @ID_medico, 
                            tipoExame = @tipoExame, urgencia = @urgencia 
                        WHERE ID_exames = @ID_exames";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, exame);
                return rowsAffected > 0;
            }
        }

        public bool DeleteExames(int id)
        {
            var sql = "DELETE FROM Exames WHERE ID_exames = @ID_exames";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, new { ID_exames = id });
                return rowsAffected > 0;
            }
        }
    }
}
