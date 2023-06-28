using Dapper;
using SHGP.Model;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SHGP.Controllers
{
    public class Resul_ExamesRepository : IResul_ExamesRepository
    {
        private readonly string _connectionString;

        public Resul_ExamesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Resul_Exames> GetResul_Exames()
        {
            var sql = "SELECT * FROM Resul_Exames";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Resul_Exames>(sql);
            }
        }

        public IEnumerable<Resul_Exames> GetResul_ExamesById(int id)
        {
            var sql = "SELECT * FROM Resul_Exames WHERE ID_res_exames = @ID_res_exames";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Resul_Exames>(sql, new { ID_res_exames = id });
            }
        }

        public bool CreateResul_Exames(Resul_Exames resulExame)
        {
            var sql = @"INSERT INTO Resul_Exames (ID_exames, pdf, resultado, data) 
                        VALUES (@ID_exames, @pdf, @resultado, @data);)";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
              
                int rowsAffected = connection.Execute(sql, resulExame);

                return rowsAffected > 0;
            }
            
        }

        public bool UpdateResul_Exames(Resul_Exames resulExame)
        {
            var sql = @"UPDATE Resul_Exames 
                        SET ID_exames = @ID_exames, pdf = @pdf, resultado = @resultado, data = @data 
                        WHERE ID_res_exames = @ID_res_exames";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, resulExame);
                return rowsAffected > 0;
            }
        }

        public bool DeleteResul_Exames(int id)
        {
            var sql = "DELETE FROM Resul_Exames WHERE ID_res_exames = @ID_res_exames";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, new { ID_res_exames = id });
                return rowsAffected > 0;
            }
        }
    }
}
