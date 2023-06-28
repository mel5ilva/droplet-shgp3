using Dapper;
using SHGP.Model;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SHGP.Controllers
{
    public class Ficha_MedicaRepository : IFicha_MedicaRepository
    {
        private readonly string _connectionString;

        public Ficha_MedicaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Ficha_Medica> GetFicha_Medica()
        {
            var sql = "SELECT * FROM Ficha_Medica";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Ficha_Medica>(sql);
            }
        }

        public IEnumerable<Ficha_Medica> GetFicha_MedicaById(int id)
        {
            var sql = "SELECT * FROM Ficha_Medica WHERE ID_ficha = @ID_ficha";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Ficha_Medica>(sql, new { ID_ficha = id });
            }
        }

        public bool CreateFicha_Medica(Ficha_Medica Ficha_Medica)
        {
            var sql = @"INSERT INTO Ficha_Medica (ID_paciente, ID_medico, Historico_medico, Tratamentos, Alergias, 
                        Doencas_cronicas, Medicamentos_em_uso, Pressao_arterial, Prontuario, Frequencia_cardiaca, 
                        Temperatura_corporal, Altura, Peso, IMC, Observacoes) 
                        VALUES (@ID_paciente, @ID_medico, @Historico_medico, @Tratamentos, @Alergias, 
                        @Doencas_cronicas, @Medicamentos_em_uso, @Pressao_arterial, @Prontuario, 
                        @Frequencia_cardiaca, @Temperatura_corporal, @Altura, @Peso, @IMC, @Observacoes);
                     ";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                int rowsAffected = connection.Execute(sql, Ficha_Medica);

                return rowsAffected > 0;
              
            }
        }

        public bool UpdateFicha_Medica(Ficha_Medica Ficha_Medica)
        {
            var sql = @"UPDATE Ficha_Medica 
                        SET ID_paciente = @ID_paciente, ID_medico = @ID_medico, 
                            Historico_medico = @Historico_medico, Tratamentos = @Tratamentos, Alergias = @Alergias, 
                            Doencas_cronicas = @Doencas_cronicas, Medicamentos_em_uso = @Medicamentos_em_uso, 
                            Pressao_arterial = @Pressao_arterial, Prontuario = @Prontuario, 
                            Frequencia_cardiaca = @Frequencia_cardiaca, Temperatura_corporal = @Temperatura_corporal, 
                            Altura = @Altura, Peso = @Peso, IMC = @IMC, Observacoes = @Observacoes 
                        WHERE ID_ficha = @ID_ficha";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, Ficha_Medica);
                return rowsAffected > 0;
            }
        }

        public bool DeleteFicha_Medica(int id)
        {
            var sql = "DELETE FROM Ficha_Medica WHERE ID_ficha = @ID_ficha";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, new { ID_ficha = id });
                return rowsAffected > 0;
            }
        }
    }
}
