using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "Usuarios")]
    public class User
    {
        public int ID_usuario { get; set; }
        public int ID_tipo_usuario { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public DateTime Data_nascimento { get; set; }
        public string? Genero { get; set; }
    }
}
