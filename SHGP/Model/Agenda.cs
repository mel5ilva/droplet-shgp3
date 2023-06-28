using System.ComponentModel.DataAnnotations.Schema;

namespace SHGP.Model
{
    [Table(name: "Agenda")]
    public class Agenda
    {
        public int ID_agenda { get; set; }
        public int ID_medico { get; set; }
        public DateOnly DataAgenda { get; set; }
        public TimeOnly HoraInicial { get; set; }
        public TimeOnly HoraFinal { get; set; }
        
    }
}