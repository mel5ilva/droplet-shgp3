using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "Agendamento")]
    public class Agendamento
    {
        public int ID_agendamento { get; set; }
        public int ID_medico { get; set; }
        public int ID_paciente { get; set; }
        public DateOnly DataAgendada { get; set; }
        public TimeOnly HoraInicial { get; set; }
        public TimeOnly HoraFinal { get; set; }
        public string? Descricao { get; set; }

    }
}