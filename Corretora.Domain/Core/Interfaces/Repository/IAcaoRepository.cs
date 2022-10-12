namespace Corretora.Domain.Core.Interfaces.Repository
{
    public interface IAcaoRepository : IRepository<Acao>
    {
        Task<Acao> GetAcaoAsync();
    }
}
