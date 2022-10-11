using Corretora.Domain.Core;
using Corretora.Domain.Core.Interfaces.Repository;
using Corretora.Repository.Context;
using Corretora.Repository.Database;

namespace Corretora.Repository.Repository
{
    public class CotacaoRepository : Repository<Cotacao>, ICotacaoRepository
    {
        public CotacaoRepository(CorretoraContext corretoraContext) : base(corretoraContext)
        {
        }
    }
}
