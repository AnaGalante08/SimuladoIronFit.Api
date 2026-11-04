namespace SimuladoIronFit.Api.Data
{
    using global::IronFit.Models;
   
    using Microsoft.EntityFrameworkCore;
    using SimuladoIronFit.Api.Models.IronFit.Models;

    namespace IronFit.Data
    {
        public class Banco : DbContext
        {
            public Banco(DbContextOptions<Banco> options)
                : base(options)
            {
            }

            public DbSet<Aluno> Alunos { get; set; }
            public DbSet<Personal> Personals { get; set; }
            public DbSet<Agendamento> Agendamentos { get; set; }
        }
    }
}
