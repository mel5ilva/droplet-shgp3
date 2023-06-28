using Dapper;
using SHGP.Model;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SHGP.Controllers
{
    public class CartaoRepository : ICartaoRepository
    {
        private readonly string _connectionString;

        public CartaoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Cartao> GetCartao()
        {
            var sql = "SELECT * FROM Cartao";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Cartao>(sql);
            }
        }

        public IEnumerable<Cartao> GetCartaoById(int id)
        {
            var sql = "SELECT * FROM Cartao WHERE ID_cartao = @ID_cartao";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Cartao>(sql, new { ID_cartao = id });
            }
        }

        public bool CreateCartao(Cartao cartao)
        {
            var sql = @"INSERT INTO Cartao (ID_paciente, Numero, Nome, Dta_validade, CVV, Saldo, Codigo) 
                        VALUES (@ID_paciente, @Numero, @Nome, @Dta_validade, @CVV, @Saldo, @Codigo);
                       ";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, cartao);
                return rowsAffected > 0;
            }
        }

        public bool UpdateCartao(Cartao cartao)
        {
            var sql = @"UPDATE Cartao 
                        SET ID_paciente = @ID_paciente, Numero = @Numero, Nome = @Nome, 
                            Dta_validade = @Dta_validade, CVV = @CVV, Saldo = @Saldo, Codigo = @Codigo 
                        WHERE ID_cartao = @ID_cartao";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, cartao);
                return rowsAffected > 0;
            }
        }

        public bool DeleteCartao(int id)
        {
            var sql = "DELETE FROM Cartao WHERE ID_cartao = @ID_cartao";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, new { ID_cartao = id });
                return rowsAffected > 0;
            }
        }
    }
}
