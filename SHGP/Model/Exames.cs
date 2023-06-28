using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "Exames")]
    public class Exames
    {
        public int ID_exames { get; set; }
        public int ID_paciente { get; set; }
        public int ID_medico { get; set; }
        public string? TipoExame { get; set; }
        public string? urgencia { get; set; }

    }
}
