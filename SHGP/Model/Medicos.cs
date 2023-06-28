using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "Medicos")]
    public class Medicos
    {
        public int ID_medico { get; set; }
        public int ID_usuario { get; set; }
        public float? salario{ get; set; }
        public DateOnly? data_admissao{ get; set; }
        public string? crm { get; set; }

    }
}
