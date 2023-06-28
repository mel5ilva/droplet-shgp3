namespace SHGP.Model
{
    public class User
    {
        public int ID_usuario { get; set; }
        public int ID_tipo_usuario { get; set; }
        public string? nome { get; set; }
        public string? email { get; set; }
        public string? senha { get; set; }
        public string? telefone { get; set; }
        public string? endereco { get; set; }
        public DateTime data_nascimento { get; set; }
        public string? genero { get; set; }
    }
}
