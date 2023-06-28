using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "ReceitasMedicas")]
    public class ReceitasMedicas
    {
        public int ID_receita { get; set; }
        public int ID_medico { get; set; }
        public int ID_paciente { get; set; }
        public string? medicamentos { get; set; }
        public string? posologia { get; set; }
        public string? recomendacoes { get; set; }
    }
}
