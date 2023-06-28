using Dapper;
using SHGP.Model;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SHGP.Controllers
{
    public class PagamentosRepository : IPagamentosRepository
    {
        private readonly string _connectionString;

        public PagamentosRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Pagamentos> GetPagamentos()
        {
            var sql = "SELECT * FROM Pagamentos";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Pagamentos>(sql);
            }
        }

        public IEnumerable<Pagamentos> GetPagamentosById(int id)
        {
            var sql = "SELECT * FROM Pagamentos WHERE ID_pagamento = @ID_pagamento";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<Pagamentos>(sql, new { ID_pagamento = id });
            }
        }

        public bool CreatePagamentos(Pagamentos pagamento)
        {
            var sql = @"INSERT INTO Pagamentos (ID_paciente, ID_consulta, Valor_pago, Metodo_pagamento, Data_pag, Time_pag) 
                        VALUES (@ID_paciente, @ID_consulta, @Valor_pago, @Metodo_pagamento, @Data_pag, @Time_pag);
                      ";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, pagamento);
                return rowsAffected > 0;
            }
        }

        public bool UpdatePagamentos(Pagamentos pagamento)
        {
            var sql = @"UPDATE Pagamentos 
                        SET ID_paciente = @ID_paciente, ID_consulta = @ID_consulta, 
                            Valor_pago = @Valor_pago, Metodo_pagamento = @Metodo_pagamento, 
                            Data_pag = @Data_pag, Time_pag = @Time_pag 
                        WHERE ID_pagamento = @ID_pagamento";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, pagamento);
                return rowsAffected > 0;
            }
        }

        public bool DeletePagamentos(int id)
        {
            var sql = "DELETE FROM Pagamentos WHERE ID_pagamento = @ID_pagamento";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                var rowsAffected = connection.Execute(sql, new { ID_pagamento = id });
                return rowsAffected > 0;
            }
        }
    }
}
