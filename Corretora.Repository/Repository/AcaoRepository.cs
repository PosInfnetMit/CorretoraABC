using Corretora.Domain.Core;
using Corretora.Domain.Core.Interfaces.Repository;
using Corretora.Repository.Context;
using Corretora.Repository.Database;

namespace Corretora.Repository.Repository
{
    public class AcaoRepository : Repository<Acao>, IAcaoRepository
    {
        public AcaoRepository(CorretoraContext corretoraContext) : base(corretoraContext)
        {
        }

     
    }
}
