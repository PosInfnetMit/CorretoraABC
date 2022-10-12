using Corretora.Domain.Core.Interfaces.Repository;
using Corretora.Repository.Context;
using Corretora.Repository.Database;
using Corretora.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Corretora.Repository
{
    public static  class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<CorretoraContext>(c =>
            {
                c.UseSqlServer(connectionString);
                c.EnableSensitiveDataLogging();
            });

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<IAcaoRepository, AcaoRepository>();
            services.AddScoped<ICotacaoRepository, CotacaoRepository>();
            

            return services;
        }
    }
}
