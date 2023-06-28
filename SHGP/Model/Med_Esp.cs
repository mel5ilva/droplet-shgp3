using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "Med_Esp")]
    public class Med_Esp
    {
        public int ID_med_esp { get; set; }
        public int ID_Especialidade { get; set; }
        public int ID_Medico { get; set; }
    }
}
