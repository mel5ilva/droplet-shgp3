using SHGP.Model;
using MySql.Data.MySqlClient;
using Dapper;
using SHGP.Controllers;

namespace SHGP.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

            public UserRepository(string connectionString)
            {
                _connectionString = connectionString;
            }

        public IEnumerable<User> GetUsers()
        {
            var sql = "SELECT * FROM Usuarios";

            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<User>(sql);
            }
        }
        public IEnumerable<User> GetUserById(int id)
        {
            var sql = "SELECT * FROM `Usuarios` WHERE `ID_usuario` = '" + id + "'";
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                return connection.Query<User>(sql);
            }
        }
        public IEnumerable<User> GetUserByemail(string email ,string senha)
        {
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Usuarios WHERE email = @Email and senha = @Senha";
                return connection.Query<User>(sql, new { Email = email,Senha = senha });
            }
        }

        public bool CreateUser(User user)
        {
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Usuarios (ID_tipo_usuario, nome, email, senha, telefone, endereco, data_nascimento, genero) VALUES (@ID_tipo_usuario, @nome, @email, @senha, @telefone, @endereco, @data_nascimento, @genero)";
                int rowsAffected = connection.Execute(sql, user);

                return rowsAffected > 0;
            }
        }
        public bool UpdateUser(User user)
        {
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                connection.Open();

                string sql = "UPDATE Usuarios SET nome = @Nome, email = @Email, senha = @Senha, telefone = @Telefone, endereco = @Endereco, data_nascimento = @DataNascimento, genero = @Genero WHERE ID_usuario = @ID_usuario";
                int rowsAffected = connection.Execute(sql, user);

                return rowsAffected > 0;
            }
        }

        public bool DeleteUser(int id)
        {
            using (MySqlConnection  connection = new MySqlConnection (_connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM Usuarios WHERE ID_usuario = @ID_usuario";
                int rowsAffected = connection.Execute(sql, new { ID_usuario = id });

                return rowsAffected > 0;
            }
        }


    }

}

