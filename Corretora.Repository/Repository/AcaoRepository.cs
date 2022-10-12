using Corretora.Domain.Core;
using Corretora.Domain.Core.Interfaces.Repository;
using Corretora.Repository.Context;
using Corretora.Repository.Database;
using Microsoft.EntityFrameworkCore;

namespace Corretora.Repository.Repository
{
    public class AcaoRepository : Repository<Acao>, IAcaoRepository
    {
        public AcaoRepository(CorretoraContext corretoraContext) : base(corretoraContext)
        {

           

        }

        public async Task<Acao> GetAcaoAsync()
        {
            return await this.Query.Include("Cotacoes")
                                    .FirstOrDefaultAsync();

        }
      

    }
}
