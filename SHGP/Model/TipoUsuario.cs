using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "TipoUsuario")]
    public class TipoUsuario
    {
        public int ID_tipo_usuario { get; set; }
        public string? descricao { get; set; }
    }
}
