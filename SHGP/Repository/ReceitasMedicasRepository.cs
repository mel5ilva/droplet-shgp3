using Dapper;
using SHGP.Model;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SHGP.Controllers
{
    public class ReceitasMedicasRepository : IReceitasMedicasRepository
    {
        private readonly string _connectionString;

        public ReceitasMedicasRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<ReceitasMedicas> GetReceitasMedicas()
        {
            var sql = "SELECT * FROM ReceitasMedicas";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<ReceitasMedicas>(sql);
            }
        }

        public IEnumerable<ReceitasMedicas> GetReceitasMedicasById(int id)
        {
            var sql = "SELECT * FROM ReceitasMedicas WHERE ID_receita = @ID_receita";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<ReceitasMedicas>(sql, id);
            }
        }

        public bool CreateReceitasMedicas(ReceitasMedicas ReceitasMedicas)
        {
            var sql = @"INSERT INTO ReceitasMedicas (ID_medico, ID_paciente, medicamentos, posologia, recomendacoes) 
                        VALUES (@ID_medico, @ID_paciente, @medicamentos, @posologia, @recomendacoes);
                        ";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.ExecuteScalar<bool>(sql, ReceitasMedicas);
            }
        }

        public bool UpdateReceitasMedicas(ReceitasMedicas ReceitasMedicas)
        {
            var sql = @"UPDATE ReceitasMedicas 
                        SET ID_medico = @ID_medico, ID_paciente = @ID_paciente, 
                            medicamentos = @medicamentos, posologia = @posologia, 
                            recomendacoes = @recomendacoes
                        WHERE ID_receita = @ID_receita";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, ReceitasMedicas);
                return rowsAffected > 0;
            }
        }

        public bool DeleteReceitasMedicas(int id)
        {
            var sql = "DELETE FROM ReceitasMedicas WHERE ID_receita = @ID_receita";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, new { ID_receita = id });
                return rowsAffected > 0;
            }
        }
    }
}
