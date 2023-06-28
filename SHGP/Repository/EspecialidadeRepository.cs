using Dapper;
using SHGP.Model;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SHGP.Controllers
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly string _connectionString;

        public EspecialidadeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Especialidade> GetEspecialidades()
        {
            var sql = "SELECT * FROM Especialidade";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Especialidade>(sql);
            }
        }

        public IEnumerable<Especialidade> GetEspecialidadeById(int id)
        {
            var sql = "SELECT * FROM Especialidade WHERE ID_Especialidade = @ID_Especialidade";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Especialidade>(sql, new { ID_Especialidade = id });
            }
        }

        public bool CreateEspecialidade(Especialidade especialidade)
        {
            var sql = @"INSERT INTO Especialidade (nome) 
                        VALUES (@nome);
                      ";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, especialidade);
                return rowsAffected > 0;
            }
        }

        public bool UpdateEspecialidade(Especialidade especialidade)
        {
            var sql = @"UPDATE Especialidade 
                        SET nome = @nome 
                        WHERE ID_Especialidade = @ID_Especialidade";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, especialidade);
                return rowsAffected > 0;
            }
        }

        public bool DeleteEspecialidade(int id)
        {
            var sql = "DELETE FROM Especialidade WHERE ID_Especialidade = @ID_Especialidade";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, new { ID_Especialidade = id });
                return rowsAffected > 0;
            }
        }
    }
}
