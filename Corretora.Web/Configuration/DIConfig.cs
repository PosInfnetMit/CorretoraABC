using Corretora.Application.App;
using Corretora.Application.Interfaces;
using Corretora.Domain.Core.Interfaces.Repository;
using Corretora.Domain.Core.Interfaces.Services;
using Corretora.Domain.Core.Services;
using Corretora.Repository.Repository;

namespace Corretora.Web.Configuration
{
    public static class DIConfig
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {
            services.AddSingleton<IAcaoApp, AcaoApp>();
            services.AddSingleton<ICotacaoApp, CotacaoApp>();
            services.AddSingleton<IFinanceiroApp, FinanceiroApp>();

            services.AddSingleton<IAcaoService, AcaoService>();
            services.AddSingleton<ICotacaoService, CotacaoService>();
            services.AddSingleton<ICIFService, CIFService>();

            services.AddSingleton<IAcaoRepository, AcaoRepository>();            
            services.AddSingleton<ICotacaoRepository, CotacaoRepository>();
            
            

            return services;
        }



    }
}
