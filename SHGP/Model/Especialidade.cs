using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "Especialidade")]
    public class Especialidade
    {
        public int ID_especialidade { get; set; }
        public string? nome { get; set; }
    }
}
