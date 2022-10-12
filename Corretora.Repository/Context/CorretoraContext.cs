using Microsoft.EntityFrameworkCore;

namespace Corretora.Repository.Context
{
    public class CorretoraContext : DbContext
    {
        public CorretoraContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CorretoraContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            // Configuração que pega todas as propriedades que são datetime e mapeiam para a coluna do tipo datetime
            configurationBuilder
                .Properties<DateTime>()
                .HaveColumnType("datetime");


            configurationBuilder
                .Properties<int>()
                .HaveColumnType("int");

            configurationBuilder
                .Properties<string>()
                .HaveColumnType("varchar");

        }
    }
}