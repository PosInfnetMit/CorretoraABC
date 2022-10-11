using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Corretora.Repository.Context
{

    public class CorretoraContextFactory : IDesignTimeDbContextFactory<CorretoraContext>
    {

        public CorretoraContext CreateDbContext(string[] args)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())                                                
                        .Build();
            var connectionString = configuration.GetConnectionString("Corretora");


            var optionsBuilder = new DbContextOptionsBuilder<CorretoraContext>();
            //builder.Configuration.AddJsonFile("errorcodes.json"
           
            optionsBuilder.UseSqlServer(connectionString);
            return new CorretoraContext(optionsBuilder.Options);

        }
    }
}
