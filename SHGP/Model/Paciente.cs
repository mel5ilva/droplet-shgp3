using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "Paciente")]
    public class Paciente
    {
        public int ID_paciente { get; set; }
        public int ID_usuario { get; set; }
        public int Nif { get; set; }

    }
}
