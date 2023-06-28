using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "Pagamentos")]
    public class Pagamentos
    {
        public int ID_pagamento{ get; set; }
        public int ID_paciente { get; set; }
        public int ID_consulta { get; set; }
        public float Valor_pago { get; set; }
        public string Metodo_pagamento { get; set; }
        public DateOnly data_pag { get; set; }
        public TimeOnly time_pag { get; set; }
    }
}
