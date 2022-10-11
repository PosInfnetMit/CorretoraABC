using Corretora.Application.App;
using Corretora.Application.Interfaces;
using Corretora.Domain.Core.Interfaces.Repository;
using Corretora.Domain.Core.Interfaces.Services;
using Corretora.Domain.Core.Services;
using Corretora.Repository.Context;
using Corretora.Repository.Database;
using Corretora.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace Corretora.Web.Configuration
{
    public static class DIConfig
    {
        public static void ResolveDependecies(this IServiceCollection services)
        {

            

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<IAcaoApp, AcaoApp>();
            services.AddScoped<ICotacaoApp, CotacaoApp>();
            services.AddScoped<IFinanceiroApp, FinanceiroApp>();
                     
            services.AddScoped<IAcaoService, AcaoService>();
            services.AddScoped<ICotacaoService, CotacaoService>();
            services.AddScoped<ICIFService, CIFService>();
                     
            services.AddScoped<IAcaoRepository, AcaoRepository>();            
            services.AddScoped<ICotacaoRepository, CotacaoRepository>();          
            

            
        }



    }
}
