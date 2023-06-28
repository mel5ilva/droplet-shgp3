using Dapper;
using SHGP.Model;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SHGP.Controllers
{
    public class MedicosRepository : IMedicosRepository
    {
        private readonly string _connectionString;

        public MedicosRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Medicos> GetMedicos()
        {
            var sql = "SELECT * FROM Medicos";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Medicos>(sql);
            }
        }

        public IEnumerable<Medicos> GetMedicosById(int id)
        {
            var sql = "SELECT * FROM Medicos WHERE ID_medico = @ID_medico";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Medicos>(sql, new { ID_medico = id });
            }
        }

        public bool CreateMedicos(Medicos medico)
        {
            var sql = @"INSERT INTO Medicos (ID_usuario, salario, data_admissao, crm) 
                        VALUES (@ID_usuario, @salario, @data_admissao, @crm);
                      ";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, medico);
                return rowsAffected > 0;
            }
        }

        public bool UpdateMedico(Medicos medico)
        {
            var sql = @"UPDATE Medicos 
                        SET ID_usuario = @ID_usuario, salario = @salario, 
                            data_admissao = @data_admissao, crm = @crm 
                        WHERE ID_medico = @ID_medico";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, medico);
                return rowsAffected > 0;
            }
        }

        public bool DeleteMedicos(int id)
        {
            var sql = "DELETE FROM Medicos WHERE ID_medico = @ID_medico";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, new { ID_medico = id });
                return rowsAffected > 0;
            }
        }
    }
}
