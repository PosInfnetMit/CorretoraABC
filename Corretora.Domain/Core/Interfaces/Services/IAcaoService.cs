namespace Corretora.Domain.Core.Interfaces.Services
{
    public interface IAcaoService : IServiceBase<Acao>
    {
        Task<Acao> GetAcaoAsync();
    }
}
