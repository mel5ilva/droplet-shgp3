using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "Ficha_Medica")]
    public class Ficha_Medica
    {
        public int ID_ficha { get; set; }
        public int ID_paciente { get; set; }
        public int ID_medico { get; set; }
        public string Historico_medico { get; set; }
        public string Tratamentos { get; set; }
        public string Alergias { get; set; }
        public string Doencas_cronicas { get; set; }
        public string Medicamentos_em_uso { get; set; }
        public string Pressao_arterial { get; set; }
        public string Prontuario { get; set; }
        public string Frequencia_cardiaca { get; set; }
        public string Temperatura_corporal { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public float IMC { get; set; }
        public string Observacoes { get; set; }
    }
}
