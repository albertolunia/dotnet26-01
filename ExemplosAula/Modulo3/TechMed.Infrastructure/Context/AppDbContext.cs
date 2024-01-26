using Microsoft.EntityFrameworkCore;
using TechMed.Core.Entities;
using TechMed.Infrastructure.Persistence.Interfaces;

namespace ResTIConnect.Infra.Data.Context
{
    public class AppDbContext : DbContext, ITechMedContext
    {

        public DbSet<Medico> MedicosCollection { get; set; }
        public DbSet<Paciente> PacientesCollection { get; set; }
        public DbSet<Atendimento> AtendimentosCollection { get; set; }
        public DbSet<Exame> ExamesCollection { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = "server=localhost;user=techmed;password=Beto@9999;database=techmed;";
            var serverVersion = ServerVersion.AutoDetect(connectionString); // pega a versão do banco de dados
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Medico>().ToTable("medico");
            modelBuilder.Entity<Paciente>().ToTable("paciente");
            modelBuilder.Entity<Atendimento>().ToTable("atendimento");
            modelBuilder.Entity<Exame>().ToTable("exame");
        }
    }
}
