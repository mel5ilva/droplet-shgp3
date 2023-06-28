using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "Cartao")]
    public class Cartao
    {
        public int ID_cartao { get; set; }
        public int ID_paciente { get; set; }
        public string? numero { get; set; }
        public string? nome { get; set; }
        public string? dta_validade { get; set; }
        public string? cvv { get; set; }
        public float saldo { get; set; }
        public string? codigo { get; set; }
    }
}