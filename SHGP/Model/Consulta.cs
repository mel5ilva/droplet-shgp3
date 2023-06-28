using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "Consulta")]
    public class Consulta
    {
        public int ID_consulta { get; set; }
        public int ID_medico { get; set; }
        public int ID_especialidade { get; set; }
        public int ID_paciente { get; set; }
        public int ID_agendamento { get; set; }
        public string? diagnostico { get; set; }
        public float preco { get; set; }
    }
}
