using Dapper;
using SHGP.Model;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace SHGP.Controllers
{
    public class Med_EspRepository: IMed_EspRepository
    {
        private readonly string _connectionString;

        public Med_EspRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Med_Esp> GetMed_Esp()
        {
            var sql = "SELECT * FROM Med_Esp";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Med_Esp>(sql);
            }
        }

        public IEnumerable<Med_Esp> GetMed_EspById(int id)
        {
            var sql = "SELECT * FROM Med_Esp WHERE ID_med_esp = @ID_med_esp";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Med_Esp>(sql, new { ID_med_esp = id });
            }
        }

        public bool CreateMed_Esp(Med_Esp Med_Esp)
        {
            var sql = @"INSERT INTO Med_Esp (ID_Especialidade, ID_Medico) 
                        VALUES (@ID_Especialidade, @ID_Medico);
                     ";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, Med_Esp);
                return rowsAffected > 0;
            }
        }

        public bool UpdateMed_Esp(Med_Esp Med_Esp)
        {
            var sql = @"UPDATE Med_Esp 
                        SET ID_Especialidade = @ID_Especialidade, ID_Medico = @ID_Medico 
                        WHERE ID_med_esp = @ID_med_esp";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, Med_Esp);
                return rowsAffected > 0;
            }
        }

        public bool DeleteMed_Esp(int id)
        {
            var sql = "DELETE FROM Med_Esp WHERE ID_med_esp = @ID_med_esp";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, new { ID_med_esp = id });
                return rowsAffected > 0;
            }
        }
    }
}
