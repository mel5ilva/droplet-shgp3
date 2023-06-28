using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "Resul_Exames")]
    public class Resul_Exames
    {
        public int ID_res_exames { get; set; }
        public int ID_exames { get; set; }
        public string pdf { get; set; }
        public string resultado { get; set; }
        public DateOnly data { get; set; }
        
    }
}