using Corretora.Application.App;
using Corretora.Application.Interfaces;
using Corretora.Domain.Core.Interfaces.Services;
using Corretora.Domain.Core.Services;

namespace Corretora.Web.Configuration
{
    public static class DIConfig
    {
        public static void ResolveDependecies(this IServiceCollection services)
        { 
            services.AddScoped<IAcaoApp, AcaoApp>();
            services.AddScoped<ICotacaoApp, CotacaoApp>();
            services.AddScoped<IFinanceiroApp, FinanceiroApp>();                     
            services.AddScoped<IAcaoService, AcaoService>();
            services.AddScoped<ICotacaoService, CotacaoService>();
            services.AddScoped<ICIFService, CIFService>();
            
        }



    }
}
