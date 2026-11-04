using IronFit.Models;

namespace SimuladoIronFit.Api.Models
{
    namespace IronFit.Models
    {
        public class Agendamento
        {
            public int Id { get; set; }

            public int AlunoId { get; set; }
            public int PersonalId { get; set; }

            public DateTime DataAgendamento { get; set; }

            public Aluno Aluno { get; set; }
            public Personal Personal { get; set; }
        }
    }
}
