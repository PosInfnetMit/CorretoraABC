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




    }
}
